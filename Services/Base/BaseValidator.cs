using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace Services.Base
{
    public abstract class BaseValidator<T> : AbstractValidator<T>
    {
        private readonly IBaseService<T> _validationEntitySettingService;
        public BaseValidator(IBaseService<T> validationEntitySettingService)
        {
            _validationEntitySettingService = validationEntitySettingService;
            AutoApplyEmptyRules();
        }
        private string ViewModelName
        {
            get { return GetType().Name.Replace("Validator", string.Empty); }
        }
        // no longer needed
        //public bool IsPropertyRequired(string propertyName)
        //{
        //    var validationSetting = _validationEntitySettingService.GetIncluding(ViewModelName);
        //    if (validationSetting != null)
        //    {
        //        return validationSetting.ValidationEntityProperties.Any(p => p.PropertyName.Equals(propertyName) && p.IsRequired);
        //    }
        //    else
        //        return false;
        //}
        protected void AddEmptyRuleFor<TProperty>(Expression<Func<T, TProperty>> expression, string message)
        {
            //RuleFor(expression).NotEmpty().When(x => IsPropertyRequired(((MemberExpression)expression.Body).Name)).WithMessage(message);
            RuleFor(expression).NotEmpty().WithMessage(message);
        }
        private void AddEmptyRuleForProperty(PropertyInfo property)
        {
            MethodInfo methodInfo = GetType().GetMethod("AddEmptyRuleFor");
            Type[] argumentTypes = new Type[] { typeof(T), property.PropertyType };
            MethodInfo genericMethod = methodInfo.MakeGenericMethod(argumentTypes);
            object propertyExpression = ExpressionHelper.CreateMemberExpressionForProperty<T>(property);
            genericMethod.Invoke(this, new object[] { propertyExpression, $"{property.Name} is a required field!" });
        }
        private PropertyInfo[] GetRequiredProperties()
        {
            var validationSetting = _validationEntitySettingService.GetIncluding(ViewModelName);
            if (validationSetting != null)
            {
                return validationSetting.ValidationEntityProperties.Where(p => p.IsRequired);
            }
            else
                return null;
        }
        private void AutoApplyEmptyRules()
        {
            PropertyInfo[] properties = GetRequiredProperties();
            if (properties == null)
                return;
            foreach (PropertyInfo propertyInfo in properties)
            {
                AddEmptyRuleForProperty(propertyInfo);
            }
        }
    }
}
