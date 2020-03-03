namespace DesignPatternsLearn.结构型设计模式.适配器模式
{
    /// <summary>
    /// 充电器。
    /// </summary>
    public interface ICharger
    {
        /// <summary>
        ///  给手机充电。
        /// </summary>
        /// <param name="type">手机类型。</param>
        void Charge(PhoneType type);
    }
}
