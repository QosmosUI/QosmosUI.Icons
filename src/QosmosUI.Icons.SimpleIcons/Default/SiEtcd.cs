// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiEtcd : ComponentBase
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
		builder.AddAttribute(15, "d", "M10.985 10.715A1.565 1.565 0 1 1 9.42 9.151a1.566 1.566 0 0 1 1.565 1.564zm2.023 0a1.565 1.565 0 1 0 1.565-1.564 1.564 1.564 0 0 0-1.565 1.564zm10.653 1.698a4.295 4.295 0 0 1-.346.013 4.517 4.517 0 0 1-1.986-.462 18.448 18.448 0 0 0 .267-3.515 18.184 18.184 0 0 0-2.274-2.695 4.519 4.519 0 0 1 1.603-1.717l.294-.182-.23-.26a11.977 11.977 0 0 0-4.182-3.05l-.319-.138-.08.336a4.506 4.506 0 0 1-1.135 2.058 18.19 18.19 0 0 0-3.277-1.35 18.126 18.126 0 0 0-3.272 1.348A4.495 4.495 0 0 1 7.594.745L7.512.408l-.317.139a12.091 12.091 0 0 0-4.182 3.05l-.23.259.294.182a4.512 4.512 0 0 1 1.599 1.708 18.322 18.322 0 0 0-2.27 2.685 18.435 18.435 0 0 0 .26 3.538 4.505 4.505 0 0 1-1.975.458 4.224 4.224 0 0 1-.346-.013L0 12.386l.032.344a11.904 11.904 0 0 0 1.609 4.924l.175.298.263-.223a4.502 4.502 0 0 1 2.132-.998 18.29 18.29 0 0 0 1.824 2.971 18.473 18.473 0 0 0 3.457.85 4.493 4.493 0 0 1-.287 2.36l-.132.319.338.075a12.048 12.048 0 0 0 2.59.286l2.59-.286.338-.075-.131-.32a4.487 4.487 0 0 1-.287-2.361 18.476 18.476 0 0 0 3.443-.848 18.208 18.208 0 0 0 1.826-2.974 4.51 4.51 0 0 1 2.143.999l.263.223.175-.296a11.877 11.877 0 0 0 1.607-4.924l.032-.343zm-7.958 4.209a13.981 13.981 0 0 1-7.416 0 14.189 14.189 0 0 1-2.256-7.013 14.118 14.118 0 0 1 2.687-2.558 14.333 14.333 0 0 1 3.279-1.784 14.377 14.377 0 0 1 3.27 1.779 14.226 14.226 0 0 1 2.7 2.576 14.293 14.293 0 0 1-.675 3.652 14.365 14.365 0 0 1-1.59 3.348z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
