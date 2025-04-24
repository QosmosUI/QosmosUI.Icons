// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiDask : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "m11.246 9.754 5.848-3.374a.202.202 0 0 0 .1-.175l.002-2.553c0-.324-.133-.645-.392-.841a1 1 0 0 0-1.118-.074l-2.425 1.4-6.436 3.712a1.007 1.007 0 0 0-.504.872l-.003 8.721v2.825c0 .324.132.645.39.842.335.253.766.278 1.12.074l2.363-1.364a.202.202 0 0 0 .101-.175l.003-8.244a1.902 1.902 0 0 1 .951-1.646Zm10.316-4.336a1.005 1.005 0 0 0-.504-.137.997.997 0 0 0-.503.137l-8.86 5.112a1.01 1.01 0 0 0-.505.87l-.003 11.591c0 .364.188.69.503.872a.995.995 0 0 0 1.007 0l8.86-5.112a1.01 1.01 0 0 0 .504-.872l.004-11.59a.997.997 0 0 0-.503-.871ZM6.378 7.074l6.334-3.655a.202.202 0 0 0 .1-.175l.001-2.193c0-.324-.133-.646-.392-.84a1 1 0 0 0-1.118-.075L2.443 5.25a1.007 1.007 0 0 0-.504.872l-.003 11.546c0 .324.133.645.39.842a1 1 0 0 0 1.12.074l1.877-1.082a.202.202 0 0 0 .1-.175l.003-8.605c0-.68.363-1.307.952-1.647z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
