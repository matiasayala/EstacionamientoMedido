namespace EstacionamientoMedido.Components.DigipModalFiles
{
    public class DigipModalOptions
    {
        public ModalSize Size { get; set; } = ModalSize.Medium;
        public bool BackgroundClickCancel { get; set; } = true;
        public int ModalBodyPadding { get; set; } = 3;
        public bool HideHeader { get; set; } = false;
        public bool HideCloseButton { get; set; } = false;
        public bool HideFooter { get; set; } = false;
        public bool ScrollableBody { get; set; } = true;
        public bool CardDesign { get; set; } = true;
        public bool StartHidden { get; set; } = false;
        public bool StartHiddenNoBackground { get; set; } = false;
        public string OkButtonText { get; set; } = "Confirmar";
    }
    public enum ModalSize
    {
        Small = 0,
        Medium = 10,
        Large = 20,
        ExtraLarge = 30,
        FullScreen = 40,
    }
}
