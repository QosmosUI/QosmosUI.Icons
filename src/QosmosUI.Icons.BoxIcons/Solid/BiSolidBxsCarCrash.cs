// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Solid;

public class BiSolidBxsCarCrash : ComponentBase
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
		builder.AddAttribute(14, "d", "M2.634 17.918a1.765 1.765 0 0 0 1.201 1.291l.18.791H4v2h16v-2H6.683a.84.84 0 0 0-.007-.278l-.196-.863 10.357-2.356.196.863a.886.886 0 0 0 1.06.667l.863-.197a.885.885 0 0 0 .667-1.06l-.251-1.103c.446-.416.67-1.046.525-1.683l-.59-2.59a1.76 1.76 0 0 0-1.262-1.307l-2.049-3.378a2.774 2.774 0 0 0-2.982-1.263l-7.868 1.79a2.769 2.769 0 0 0-2.144 2.43l-.387 3.932a1.76 1.76 0 0 0-.57 1.724l.589 2.59zm3.02-.688a1.327 1.327 0 1 1-.59-2.589 1.327 1.327 0 0 1 .59 2.589zm11.222-2.552a1.328 1.328 0 1 1-.59-2.587 1.328 1.328 0 0 1 .59 2.587zM5.589 9.192l7.869-1.791a.773.773 0 0 1 .83.351l1.585 2.613-.566.129-10.046 2.287-.568.129.299-3.042a.772.772 0 0 1 .597-.676zM18.405 4 17 2l-.5 3L19 9l3 1-2-2.539 2-.933-2-.933L22 2z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
