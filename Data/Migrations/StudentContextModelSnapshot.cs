// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(StudentContext))]
    partial class StudentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Data.Entities.Attendence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("EditBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EditOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IssStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Remarks")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int?>("StudentId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Attendence");
                });

            modelBuilder.Entity("Data.Entities.ClassRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("EditBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EditOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GradeId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Remarks")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Section")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<int?>("TeacherId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.HasKey("Id");

                    b.HasIndex("GradeId");

                    b.HasIndex("TeacherId");

                    b.ToTable("ClassRoom");
                });

            modelBuilder.Entity("Data.Entities.ClassRoomStudent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ClassRoomId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("EditBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EditOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("StudentId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassRoomId");

                    b.HasIndex("StudentId");

                    b.ToTable("ClassRoomStudent");
                });

            modelBuilder.Entity("Data.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("EditBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EditOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GradeId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("Id");

                    b.HasIndex("GradeId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("Data.Entities.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("EditBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EditOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ExamTypeId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ExamTypeId");

                    b.ToTable("Exam");
                });

            modelBuilder.Entity("Data.Entities.ExamResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CourseId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("EditBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EditOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ExamId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Marks")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int?>("StudentId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("ExamId");

                    b.HasIndex("StudentId");

                    b.ToTable("ExamResult");
                });

            modelBuilder.Entity("Data.Entities.ExamType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("EditBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EditOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("Id");

                    b.ToTable("ExamType");
                });

            modelBuilder.Entity("Data.Entities.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("EditBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EditOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("Id");

                    b.ToTable("Grade");
                });

            modelBuilder.Entity("Data.Entities.Parent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("EditBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EditOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsStatus")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<DateTime?>("LastloginDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastloginIp")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Mobile")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Password")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Phone")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Parent");
                });

            modelBuilder.Entity("Data.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfJoin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("EditBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EditOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsStatus")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<DateTime?>("LastloginDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastloginIp")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Mobile")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int?>("ParentId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Phone")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Data.Entities.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfJoin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("EditBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EditOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsStatus")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<DateTime?>("LastloginDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastloginIp")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Mobile")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Password")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Phone")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("Data.Entities.Attendence", b =>
                {
                    b.HasOne("Data.Entities.Student", "Student")
                        .WithMany("Attendence")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Data.Entities.ClassRoom", b =>
                {
                    b.HasOne("Data.Entities.Grade", "Grade")
                        .WithMany("ClassRoom")
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.Teacher", "Teacher")
                        .WithMany("ClassRoom")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grade");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Data.Entities.ClassRoomStudent", b =>
                {
                    b.HasOne("Data.Entities.ClassRoom", "ClassRoom")
                        .WithMany("ClassRoomStudent")
                        .HasForeignKey("ClassRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.Student", "Student")
                        .WithMany("ClassRoomStudent")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClassRoom");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Data.Entities.Course", b =>
                {
                    b.HasOne("Data.Entities.Grade", "Grade")
                        .WithMany("Course")
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grade");
                });

            modelBuilder.Entity("Data.Entities.Exam", b =>
                {
                    b.HasOne("Data.Entities.ExamType", "ExmpType")
                        .WithMany("Exam")
                        .HasForeignKey("ExamTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExmpType");
                });

            modelBuilder.Entity("Data.Entities.ExamResult", b =>
                {
                    b.HasOne("Data.Entities.Course", "Course")
                        .WithMany("ExamResult")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.Exam", "Exam")
                        .WithMany("ExamResult")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.Student", "Student")
                        .WithMany("ExamResult")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Exam");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Data.Entities.Student", b =>
                {
                    b.HasOne("Data.Entities.Parent", "Parent")
                        .WithMany("Student")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Data.Entities.ClassRoom", b =>
                {
                    b.Navigation("ClassRoomStudent");
                });

            modelBuilder.Entity("Data.Entities.Course", b =>
                {
                    b.Navigation("ExamResult");
                });

            modelBuilder.Entity("Data.Entities.Exam", b =>
                {
                    b.Navigation("ExamResult");
                });

            modelBuilder.Entity("Data.Entities.ExamType", b =>
                {
                    b.Navigation("Exam");
                });

            modelBuilder.Entity("Data.Entities.Grade", b =>
                {
                    b.Navigation("ClassRoom");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Data.Entities.Parent", b =>
                {
                    b.Navigation("Student");
                });

            modelBuilder.Entity("Data.Entities.Student", b =>
                {
                    b.Navigation("Attendence");

                    b.Navigation("ClassRoomStudent");

                    b.Navigation("ExamResult");
                });

            modelBuilder.Entity("Data.Entities.Teacher", b =>
                {
                    b.Navigation("ClassRoom");
                });
#pragma warning restore 612, 618
        }
    }
}
