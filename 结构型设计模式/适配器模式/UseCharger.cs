namespace DesignPatternsLearn.结构型设计模式.适配器模式
{
    /// <summary>
    /// 使用充电器。
    /// </summary>
    public class UseCharger
    {
        /// <summary>
        /// 给手机充电进行测试。
        /// </summary>
        public static void Use()
        {
            // 使用 iPhone 充电器
            var iPhoneCharger = new iPhoneCharger();
            iPhoneCharger.iPhoneCharge(PhoneType.iPhone);
            iPhoneCharger.iPhoneCharge(PhoneType.Android);
            iPhoneCharger.iPhoneCharge(PhoneType.Other);

            // 使用 Android 充电器
            var androidCharger = new AndroidCharger();
            androidCharger.AndroidCharge(PhoneType.Android);
            androidCharger.AndroidCharge(PhoneType.iPhone);
            androidCharger.AndroidCharge(PhoneType.Other);

            // 使用充电适配器（类适配器）
            var adapter1 = new MultitapAdapter();
            adapter1.iPhoneCharge(PhoneType.iPhone);
            adapter1.AndroidCharge(PhoneType.Android);

            // 推荐：使用充电适配器（对象适配器）
            var adapter2 = new ChargeAdapter();
            adapter2.Charge(PhoneType.iPhone);
            adapter2.Charge(PhoneType.Android);
            adapter2.Charge(PhoneType.Other);
        }
    }
}
