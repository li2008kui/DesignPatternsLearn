using System;

namespace DesignPatternsLearn.结构型设计模式.适配器模式
{
    /// <summary>
    /// 充电适配器（对象适配器）。
    /// </summary>
    public class ChargeAdapter : ICharger
    {
        private readonly iPhoneCharger iPhoneCharger;
        private readonly AndroidCharger androidCharger;

        /// <summary>
        /// 初始化两种类型的充电器。
        /// </summary>
        public ChargeAdapter()
        {
            iPhoneCharger = new iPhoneCharger();
            androidCharger = new AndroidCharger();
        }

        /// <summary>
        /// 根据手机类型选择适合的充电器进行充电。
        /// </summary>
        /// <param name="type">手机类型。</param>
        public void Charge(PhoneType type)
        {
            switch (type)
            {
                case PhoneType.iPhone:
                    iPhoneCharger.iPhoneCharge(type);
                    break;
                case PhoneType.Android:
                    androidCharger.AndroidCharge(type);
                    break;
                case PhoneType.Other:
                default:
                    Console.WriteLine("接口不匹配，无法给iPhone或Android以外的手机充电！");
                    break;
            }
        }
    }
}
