
// This file has been generated by the GUI designer. Do not modify.
namespace DE
{
	public partial class KeyWindow
	{
		private global::DE.ShowKeyIv showkeyiv1;
		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget DE.KeyWindow
			this.Name = "DE.KeyWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("KeyWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child vbox2.Gtk.Box+BoxChild
			this.showkeyiv1 = new global::DE.ShowKeyIv();
			this.showkeyiv1.Name = "showkeyiv1";
			this.Add(this.showkeyiv1);
		if ((this.Child != null))
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 150;
			this.Show();
		}
	}
}