﻿using DV8.Html.Framework;

namespace DV8.Html.Elements;

public class H1 : HtmlElement
{
    protected override bool IsInlineBlock => true;
    public H1()
    {
    }

    public H1(string txt) : base(null, txt)
    {
    }
}