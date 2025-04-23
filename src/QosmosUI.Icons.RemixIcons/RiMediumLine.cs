// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiMediumLine : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 24 24";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M6.15791 4H17.8422C19.034 4 20.0001 4.96612 20.0001 6.15789V9.61314C19.8226 9.65789 19.653 9.71748 19.5077 9.79063C19.1077 9.97583 18.7549 10.2528 18.4614 10.6162C17.9888 11.2018 17.7026 11.9931 17.633 12.8824C17.6181 13.059 17.6132 13.2366 17.6164 13.4138C17.6574 15.1766 18.4959 16.6295 20.0001 16.9647V17.8421C20.0001 19.0339 19.034 20 17.8422 20H6.15791C4.96613 20 4.00001 19.0339 4.00001 17.8421V6.15789C4.00001 4.96612 4.96613 4 6.15791 4ZM21.0001 6.15789C21.0001 4.41384 19.5863 3 17.8422 3H6.15791C4.41385 3 3 4.41384 3 6.15789V17.8421C3 19.5862 4.41385 21 6.15791 21H17.8422C19.5863 21 21.0001 19.5862 21.0001 17.8421V6.15789ZM20.0001 10.298V12.2813H19.3839C19.4227 11.4139 19.6365 10.7014 20.0001 10.298ZM20.0001 12.6621V14.7252C19.5588 14.2117 19.3013 13.4758 19.3474 12.6621H20.0001ZM17.6974 7.30004L17.7116 7.29693V7.18701H14.8128L12.1212 13.5132L9.42956 7.18701H6.30575V7.29693L6.31977 7.30004C6.84888 7.41946 7.11751 7.59757 7.11751 8.23987V15.7595C7.11751 16.4018 6.84784 16.5799 6.31874 16.6993L6.30471 16.7024V16.8127H8.42412V16.7028L8.41011 16.6996C7.88098 16.5802 7.61235 16.4021 7.61235 15.7598V8.67605L11.07 16.8127H11.2661L14.8246 8.44914V15.9455C14.7792 16.4528 14.513 16.6095 14.0339 16.7176L14.0197 16.7209V16.83H17.7116V16.7209L17.6974 16.7176C17.2178 16.6095 16.9452 16.4528 16.8999 15.9455L16.8974 8.23987H16.8999C16.8999 7.59757 17.1685 7.41946 17.6974 7.30004Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
