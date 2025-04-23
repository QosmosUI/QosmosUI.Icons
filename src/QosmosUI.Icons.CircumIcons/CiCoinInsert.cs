// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiCoinInsert : ComponentBase
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
		builder.AddAttribute(14, "id", "Coin_Insert");
		builder.AddAttribute(15, "data-name", "Coin Insert");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M21.44,17.7H17.77a7.484,7.484,0,0,0,1.78-4.86A7.55,7.55,0,1,0,6.23,17.7H2.56a.508.508,0,0,0-.5.5.5.5,0,0,0,.5.5H21.44a.5.5,0,0,0,.5-.5A.508.508,0,0,0,21.44,17.7Zm-5.03,0H7.62a6.546,6.546,0,1,1,8.78-.01Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M14,13.965a1.616,1.616,0,0,1-1.5,1.61v.65a.485.485,0,0,1-.5.48.491.491,0,0,1-.5-.48v-.64h-.81a.5.5,0,0,1-.5-.5.508.508,0,0,1,.5-.5h1.69a.617.617,0,0,0,.62-.62.623.623,0,0,0-.62-.62h-.75a1.618,1.618,0,0,1-.13-3.23v-.65a.491.491,0,0,1,.5-.48.485.485,0,0,1,.5.48v.64h.81a.5.5,0,0,1,0,1H11.63a.62.62,0,0,0,0,1.24h.75A1.626,1.626,0,0,1,14,13.965Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
