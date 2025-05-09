// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiStaplerPneumatic : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M388.1 86.51c-21.4 0-38.7 15.29-38.7 34.09v16.6h131.2v-16.6c0-18.8-17.4-34.09-38.8-34.09zm-258 42.79V196L90.54 304.6H80.11c-16.06 0-29.09 13.1-29.09 29.2h79.08L173 209.9v-80.6zm59.9 0V196h87.4v-66.7zm104.3 0V197l19 58.3h22.6l-11.3-102.2v-23.8zM82.19 140.4v13.8H62.77v-13.5H45.78v13.5H27.05v17h18.73v13.4h16.99v-13.4h19.42v13.4h32.11v-44.2zm267.41 18.2 13.7 130.6h104.1L481 158.6zm-62.8 113.7c-1.9 0-3.7.5-5 1.7l-18.7 13.3 10 13.8 16.4-11.8h50.1l-1.8-17zm-120.3 28.6c-3.6 0-6.9 2.2-8 5.5l-9.9 27.4h18.2l5.7-16h32.4v-16.9zM364 309v18.8h31V309zm56.6 0v116.5h13.7L455.4 309zM50.97 353v44.7H394.9V353z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
