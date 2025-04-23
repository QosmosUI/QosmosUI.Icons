// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiPalette : ComponentBase
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
		builder.AddAttribute(14, "id", "Palette");
		builder.OpenElement(15, "g");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M19.31,20.93a1.62,1.62,0,0,0,1.62-1.62V15.93a1.62,1.62,0,0,0-1.62-1.62H14.37l4.66-4.66a1.642,1.642,0,0,0,0-2.3L16.64,4.96a1.636,1.636,0,0,0-2.3,0L9.69,9.62V4.56a1.5,1.5,0,0,0-1.5-1.5H4.57a1.5,1.5,0,0,0-1.5,1.5V18.44a2.507,2.507,0,0,0,2.5,2.5ZM9.69,11.04l5.36-5.37a.628.628,0,0,1,.88,0l2.39,2.39a.628.628,0,0,1,0,.88L9.69,17.57ZM4.07,4.56a.5.5,0,0,1,.5-.5H8.19a.5.5,0,0,1,.5.5V8.48H4.07Zm0,4.92H8.69v4.43H4.07ZM7.29,19.93l-1.72.01a1.5,1.5,0,0,1-1.5-1.5V14.91H8.69v3.53a1.5,1.5,0,0,1-1.4,1.49m12.64-.62a.623.623,0,0,1-.62.62H9.19a2.381,2.381,0,0,0,.42-.86l3.76-3.76h5.94a.623.623,0,0,1,.62.62Z");
		builder.CloseElement();
		builder.OpenElement(18, "circle");
		builder.AddAttribute(19, "cx", "6.382");
		builder.AddAttribute(20, "cy", "17.419");
		builder.AddAttribute(21, "r", "0.844");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
