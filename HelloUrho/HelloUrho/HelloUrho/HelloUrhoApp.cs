using System;
using System.Collections.Generic;
using System.Text;
using Urho;
using Urho.Gui;

namespace HelloUrho
{
    class HelloUrhoApp : Urho.Application
    {
        public HelloUrhoApp(ApplicationOptions options) : base(options)
        {
        }

        protected override void Start()
        {
            base.Start();　// 必須

            var helloText = new Text()
            {
                Value = "Hello Urho",
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
            };

            // フォントの指定は必須
            helloText.SetFont(CoreAssets.Fonts.AnonymousPro, 80f);

            this.UI.Root.AddChild(helloText);
        }
    }
}
