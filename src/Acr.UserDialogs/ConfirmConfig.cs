using System;


namespace Acr.UserDialogs
{

    public class ConfirmConfig : IStandardDialogConfig, IAndroidStyleDialogConfig
    {
        public static bool DefaultUseYesNo { get; set; }
        public static string DefaultYes { get; set; } = "Yes";
        public static string DefaultNo { get; set; } = "No";
        public static string DefaultOkText { get; set; } = "Ok";
        public static string DefaultCancelText { get; set; } = "Cancel";
        public static int? DefaultAndroidStyleId { get; set; }
        public static ActionStyle DefaultActionStyle { get; set; } = ActionStyle.LeftNormalRightBold;


        public string Title { get; set; }
        public string Message { get; set; }
        public int? AndroidStyleId { get; set; } = DefaultAndroidStyleId;
        public Action<bool> OnAction { get; set; }
        //public bool UwpCancelOnEscKey { get; set; }
        //public bool UwpSubmitOnEnterKey { get; set; }

        public bool IsCancellable { get; set; } = true;

        public string OkText { get; set; } = !DefaultUseYesNo ? DefaultOkText : DefaultYes;
        public string CancelText { get; set; } = !DefaultUseYesNo ? DefaultCancelText : DefaultNo;

        public ActionStyle DialogActionStyle { get; set; } = DefaultActionStyle;

        public ConfirmConfig UseYesNo()
        {
            this.OkText = DefaultYes;
            this.CancelText = DefaultNo;
            return this;
        }


        public ConfirmConfig SetTitle(string title)
        {
            this.Title = title;
            return this;
        }


        public ConfirmConfig SetMessage(string message)
        {
            this.Message = message;
            return this;
        }


        public ConfirmConfig SetOkText(string text)
        {
            this.OkText = text;
            return this;
        }


        public ConfirmConfig SetAction(Action<bool> action)
        {
            this.OnAction = action;
            return this;
        }


        public ConfirmConfig SetCancelText(string text)
        {
            this.CancelText = text;
            return this;
        }

        public ConfirmConfig SetCancellable(bool cancel)
        {
            this.IsCancellable = cancel;
            return this;
        }

        public ConfirmConfig SetActionStyle(ActionStyle style)
        {
            this.DialogActionStyle = style;
            return this;
        }
    }

    public enum ActionStyle
    {
        LeftNormalRightNormal,
        LeftNormalRightBold,
        LeftRedBoldRightNormal
    }
}
