﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Aaa
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Сотрудники.
    /// </summary>
    // *** Start programmer edit section *** (Сотрудники CustomAttributes)

    // *** End programmer edit section *** (Сотрудники CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СотрудникиE", new string[] {
            "Номер as \'Номер\'",
            "Фио as \'Фио\'",
            "Телефон as \'Телефон\'"})]
    public class Сотрудники : ICSSoft.STORMNET.DataObject
    {
        
        private int fНомер;
        
        private string fФио;
        
        private string fТелефон;
        
        private IIS.Aaa.Согласие fСогласие;
        
        // *** Start programmer edit section *** (Сотрудники CustomMembers)

        // *** End programmer edit section *** (Сотрудники CustomMembers)

        
        /// <summary>
        /// Номер.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.Номер CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.Номер CustomAttributes)
        public virtual int Номер
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.Номер Get start)

                // *** End programmer edit section *** (Сотрудники.Номер Get start)
                int result = this.fНомер;
                // *** Start programmer edit section *** (Сотрудники.Номер Get end)

                // *** End programmer edit section *** (Сотрудники.Номер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.Номер Set start)

                // *** End programmer edit section *** (Сотрудники.Номер Set start)
                this.fНомер = value;
                // *** Start programmer edit section *** (Сотрудники.Номер Set end)

                // *** End programmer edit section *** (Сотрудники.Номер Set end)
            }
        }
        
        /// <summary>
        /// Телефон.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.Телефон CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.Телефон CustomAttributes)
        [StrLen(255)]
        public virtual string Телефон
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.Телефон Get start)

                // *** End programmer edit section *** (Сотрудники.Телефон Get start)
                string result = this.fТелефон;
                // *** Start programmer edit section *** (Сотрудники.Телефон Get end)

                // *** End programmer edit section *** (Сотрудники.Телефон Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.Телефон Set start)

                // *** End programmer edit section *** (Сотрудники.Телефон Set start)
                this.fТелефон = value;
                // *** Start programmer edit section *** (Сотрудники.Телефон Set end)

                // *** End programmer edit section *** (Сотрудники.Телефон Set end)
            }
        }
        
        /// <summary>
        /// Фио.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.Фио CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.Фио CustomAttributes)
        [StrLen(255)]
        public virtual string Фио
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.Фио Get start)

                // *** End programmer edit section *** (Сотрудники.Фио Get start)
                string result = this.fФио;
                // *** Start programmer edit section *** (Сотрудники.Фио Get end)

                // *** End programmer edit section *** (Сотрудники.Фио Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.Фио Set start)

                // *** End programmer edit section *** (Сотрудники.Фио Set start)
                this.fФио = value;
                // *** Start programmer edit section *** (Сотрудники.Фио Set end)

                // *** End programmer edit section *** (Сотрудники.Фио Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.Aaa.Согласие.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.Согласие CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.Согласие CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "Согласие"})]
        public virtual IIS.Aaa.Согласие Согласие
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.Согласие Get start)

                // *** End programmer edit section *** (Сотрудники.Согласие Get start)
                IIS.Aaa.Согласие result = this.fСогласие;
                // *** Start programmer edit section *** (Сотрудники.Согласие Get end)

                // *** End programmer edit section *** (Сотрудники.Согласие Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.Согласие Set start)

                // *** End programmer edit section *** (Сотрудники.Согласие Set start)
                this.fСогласие = value;
                // *** Start programmer edit section *** (Сотрудники.Согласие Set end)

                // *** End programmer edit section *** (Сотрудники.Согласие Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СотрудникиE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СотрудникиE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СотрудникиE", typeof(IIS.Aaa.Сотрудники));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of Сотрудники.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfСотрудники CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfСотрудники CustomAttributes)
    public class DetailArrayOfСотрудники : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.Aaa.DetailArrayOfСотрудники members)

        // *** End programmer edit section *** (IIS.Aaa.DetailArrayOfСотрудники members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type Сотрудники by index.
        /// </summary>
        /// <summary>
        /// Adds object with type Сотрудники.
        /// </summary>
        public DetailArrayOfСотрудники(IIS.Aaa.Согласие fСогласие) : 
                base(typeof(Сотрудники), ((ICSSoft.STORMNET.DataObject)(fСогласие)))
        {
        }
        
        public IIS.Aaa.Сотрудники this[int index]
        {
            get
            {
                return ((IIS.Aaa.Сотрудники)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.Aaa.Сотрудники dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
