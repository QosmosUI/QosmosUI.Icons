// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons.Default;

public class GrCar : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "stroke-width", "2");
		builder.AddAttribute(16, "d", "M1,10.9970301 C1,10.4463856 1.43945834,10 2.00246167,10 L21.9975383,10 C22.5511826,10 23,10.4530363 23,10.9970301 L23,17.0029699 C23,17.5536144 22.5605417,18 21.9975383,18 L2.00246167,18 C1.44881738,18 1,17.5469637 1,17.0029699 L1,10.9970301 Z M6,2 L18,2 L22,10 L2,10 L6,2 Z M12,10.5 L15,5 M3,18 L6,18 L6,20.9906311 C6,21.5480902 5.55733967,22 5.00104344,22 L3.99895656,22 C3.44724809,22 3,21.5566468 3,20.9906311 L3,18 Z M18,18 L21,18 L21,20.9906311 C21,21.5480902 20.5573397,22 20.0010434,22 L18.9989566,22 C18.4472481,22 18,21.5566468 18,20.9906311 L18,18 Z M5,15 C5.55228475,15 6,14.5522847 6,14 C6,13.4477153 5.55228475,13 5,13 C4.44771525,13 4,13.4477153 4,14 C4,14.5522847 4.44771525,15 5,15 Z M19,15 C19.5522847,15 20,14.5522847 20,14 C20,13.4477153 19.5522847,13 19,13 C18.4477153,13 18,13.4477153 18,14 C18,14.5522847 18.4477153,15 19,15 Z M12,13 L12,15 M14,13 L14,15 M10,13 L10,15");
		builder.CloseElement();
		builder.CloseElement();
    }
}
