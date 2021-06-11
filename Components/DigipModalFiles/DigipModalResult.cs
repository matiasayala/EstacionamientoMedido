namespace EstacionamientoMedido.Components.DigipModalFiles
{
    public class DigipModalResult
    {
        public bool IsOk { get; }

        protected DigipModalResult(bool IsOk)
        {
            this.IsOk = IsOk;
        }

        public static DigipModalResult Ok()
        {
            return new DigipModalResult(true);
        }

        public static DigipModalResult Cancel()
        {
            return new DigipModalResult(false);
        }
    }

}
