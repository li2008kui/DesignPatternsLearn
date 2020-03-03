using System;

namespace DesignPatternsLearn.结构型设计模式.适配器模式
{
    /// <summary>
    /// 充电适配器（类适配器）。
    /// </summary>
    public class MultitapAdapter : AndroidCharger, ILightningCharger
    {
        /// <summary>
        /// 给 iPhone 手机充电。
        /// </summary>
        /// <param name="type">手机类型。</param>
        public void iPhoneCharge(PhoneType type)
        {
            if (type == PhoneType.iPhone)
            {
                Console.WriteLine("正在给iPhone手机充电");
            }
            else
            {
                Console.WriteLine("接口不匹配，无法给iPhone以外的手机充电！");
            }
        }
    }
}
