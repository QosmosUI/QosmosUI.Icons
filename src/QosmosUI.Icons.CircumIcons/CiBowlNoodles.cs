// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiBowlNoodles : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "id", "Bowl_Noodles");
		builder.AddAttribute(15, "data-name", "Bowl & Noodles");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M19.5,10.705a.948.948,0,0,0-.92-.67h-5.07V8.355l4.75.17h.02a.734.734,0,0,0,.73-.73.718.718,0,0,0-.75-.72l-4.75.17V5.405l4.78-.67a.723.723,0,0,0,.62-.72.487.487,0,0,0-.01-.12.716.716,0,0,0-.87-.58l-4.6.98a1.5,1.5,0,0,0-2.92.47v.15l-1.14.24a1.494,1.494,0,0,0-2.86.61v.01l-1.2.25a.267.267,0,0,0-.2.26v.04a.257.257,0,0,0,.29.21l1.11-.15V7.5l-1.25.04a.263.263,0,0,0-.25.26.256.256,0,0,0,.25.26l1.25.04v1.94H5.425a.963.963,0,0,0-.92.68,10.119,10.119,0,0,0,1.19,8.53l.61.92a1.233,1.233,0,0,0,1.05.57h9.3a1.228,1.228,0,0,0,1.04-.57l.61-.92A10.136,10.136,0,0,0,19.5,10.705Zm-7.99-5.94a.5.5,0,0,1,.5-.5.5.5,0,0,1,.5.5v5.24h-1Zm-2,1.2,1-.14v1.53l-1,.03Zm0,2.25,1,.03v1.79h-1Zm-2-2.45a.5.5,0,0,1,.5-.5.5.5,0,0,1,.5.5v4.24h-1Zm9.96,12.93-.6.93a.261.261,0,0,1-.21.11h-9.3a.236.236,0,0,1-.21-.11l-.61-.93a9.229,9.229,0,0,1-1.11-7.66l13.12-.03A9.122,9.122,0,0,1,17.465,18.7Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
