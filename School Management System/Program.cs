using Data;
using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.Base;
//using School_Management_System.Middleware.ExceptionHandling;
using Services;
using Services.BackgroundWoker;
using Services.Base;
using Services.StudentFolder;
var builder = WebApplication.CreateBuilder(args);
///var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy(name: MyAllowSpecificOrigins,
//                      builder =>
//                      {
//                          builder.WithOrigins("https://localhost:7098"
//                                              );
//                      });
//});
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddHostedService<BackgroungQueueService>();
builder.Services.AddSingleton<IBackgroundQueue, BackgroundQueue>();
var connectionString = builder.Configuration["ConnectionStrings:DefaultConnection"];
builder.Services.AddDbContext<StudentContext>(options =>
{
    options.UseSqlServer(connectionString);
});
//builder.Services.AddTransient<ExceptionHandlingMiddleware>(); 
//bui services.AddTransient(typeof(ILogger<>),typeof(FileLogger<>));  
builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
builder.Services.AddScoped<IAttendenceRepository, AttendenceRepository>();
builder.Services.AddScoped<IAttendenceService, AttendenceService>();
builder.Services.AddScoped<IClassRoomRepository, ClassRoomRepository>();
builder.Services.AddScoped<IClassRoomService, ClassRoomService>();
builder.Services.AddScoped<IClassRoomStudentRepository, ClassRoomStudentRepository>();
builder.Services.AddScoped<IClassRoomStudentService, ClassRoomStudentService>();

builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<IExamRepository, ExamRepository>();
builder.Services.AddScoped<IExamService, ExamService>();

builder.Services.AddScoped<IExamTypeRepository, ExamTypeRepository>();
builder.Services.AddScoped<IExamTypeService, ExamTypeService>();

builder.Services.AddScoped<IGradeRepository, GradeRepository>();
builder.Services.AddScoped<IGradeService, GradeService>();

builder.Services.AddScoped<IParentRepository, ParentRepository>();
builder.Services.AddScoped<IParentService, ParentService>();

builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<ITeacherRepository, TeacherRepository>();
builder.Services.AddScoped<ITeacherService, TeacherService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Employee API V1");
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.UseCors(policy => policy.AllowAnyHeader()
                            .AllowAnyMethod()
                            .SetIsOriginAllowed(origin => true)
                            .AllowCredentials());
//app.UseMiddleware<ExceptionHandlingMiddleware>();
app.MapControllers();
app.Run();
