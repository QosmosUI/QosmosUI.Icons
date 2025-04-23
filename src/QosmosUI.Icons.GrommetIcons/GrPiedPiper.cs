// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons;

public class GrPiedPiper : ComponentBase
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
		builder.AddAttribute(14, "fill-rule", "evenodd");
		builder.AddAttribute(15, "d", "M0,19.4210526 C2.2736843,19.4210526 4.04210525,18.6631579 4.04210525,18.6631579 C4.04210525,18.6631579 7.0736842,11.0842105 11.368421,11.0842105 C14.6526316,11.0842105 15.1578947,13.6105264 15.1578947,13.6105264 C15.1578947,13.6105264 19.9578947,4.26315788 24,3 C20.2105263,6.03157895 20.7157895,9.31578948 18.9473684,10.831579 C17.1789474,12.3473684 17.1789477,10.8381579 15.1578951,14.375 C10.6105267,14.8802632 9.125,16.3894739 6.06315789,18.1578947 C11.3684206,15.6315794 12.3789474,15.3789474 17.1789474,15.631579 C17.6828892,15.6581022 17.9368421,15.8842105 17.6842105,16.3894737 C16.951256,17.8553827 16.4037001,20.0617486 15.4105263,19.9263158 C9.85263157,19.1684211 6.56842104,20.431579 3.78947367,20.431579 C1.0105263,20.431579 0,19.9263158 0,19.4210526 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
