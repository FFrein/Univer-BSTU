using __4_5__ООТПиСП;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LR4_5_TryOne
{
    internal class MyControlOne : FrameworkElement
    {
        //1. Создаём свойство зависимости
        //Идентификатор свойства зависимости - поле представляющее свойство зависимости
        public static DependencyProperty DataProperty;

        //2. регистрация свойства зависимости
        static MyControlOne()
        {
            //Параметр 1: Имя свойства
            //Параметр 2: Тип данных свойства
            //Параметр 3: Тип, которому принадлежит это свойство
            //Параметр 4:
            //Параметр 5: 
            try
            {
                FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();

                metadata.CoerceValueCallback = new CoerceValueCallback(CorrectValue);

                DataProperty = DependencyProperty.Register(
                    "DataPrice",
                    typeof(string),
                    typeof(MyControlOne)
                    ,metadata,new ValidateValueCallback(ValidateValue)
                    );
            }
            catch(Exception e) { }
        }
        // 3. Валидатор входных данных

        private static bool ValidateValue(object value)
        {
            try
            {
                if (value != null)
                {
                    int currentValue = Convert.ToInt32(value);
                    if (currentValue >= 0) // если текущее значение от нуля и выше
                        return true;

                    return false;
                }
                else { return true; }
            }
            catch(Exception e) {
                
                return true;
            }
        }

        // 4. Корректор
        private static object CorrectValue(DependencyObject d, object baseValue)
        {
            try
            {
                if (baseValue != null)
                {
                    int currentValue = Convert.ToInt32(baseValue);
                    if (currentValue > 1000)  // если больше 1000, возвращаем 1000
                        return "1000";
                    return currentValue.ToString(); // иначе возвращаем текущее значение
                }

                return null;
            }
            catch(Exception e) 
            {
                
                return null; 
            }
        }


        // 5. Упаковка свойств зависимоси унаслеованное свойство.
        // Метод SetValue и GetValue унаследованны от класса DependencyProperty

        public string DataPrice
        {
            get
            {
                return (string)GetValue(DataProperty);
            }
            set
            {
                try
                {
                    SetValue(DataProperty, value);
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

        }
    }
}
