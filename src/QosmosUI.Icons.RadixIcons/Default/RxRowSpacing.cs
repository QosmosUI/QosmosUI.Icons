// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RadixIcons.Default;

public class RxRowSpacing : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "15";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "none";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 15 15";

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
		builder.AddAttribute(15, "clip-rule", "evenodd");
		builder.AddAttribute(16, "d", "M7.81832 0.68179C7.64258 0.506054 7.35766 0.506054 7.18192 0.68179L5.18192 2.68179C5.00619 2.85753 5.00619 3.14245 5.18192 3.31819C5.35766 3.49392 5.64258 3.49392 5.81832 3.31819L7.05012 2.08638L7.05012 5.50023C7.05012 5.74876 7.25159 5.95023 7.50012 5.95023C7.74865 5.95023 7.95012 5.74876 7.95012 5.50023L7.95012 2.08638L9.18192 3.31819C9.35766 3.49392 9.64258 3.49392 9.81832 3.31819C9.99406 3.14245 9.99406 2.85753 9.81832 2.68179L7.81832 0.68179ZM7.95012 12.9136V9.50023C7.95012 9.2517 7.74865 9.05023 7.50012 9.05023C7.25159 9.05023 7.05012 9.2517 7.05012 9.50023V12.9136L5.81832 11.6818C5.64258 11.5061 5.35766 11.5061 5.18192 11.6818C5.00619 11.8575 5.00619 12.1424 5.18192 12.3182L7.18192 14.3182C7.26632 14.4026 7.38077 14.45 7.50012 14.45C7.61947 14.45 7.73393 14.4026 7.81832 14.3182L9.81832 12.3182C9.99406 12.1424 9.99406 11.8575 9.81832 11.6818C9.64258 11.5061 9.35766 11.5061 9.18192 11.6818L7.95012 12.9136ZM1.49994 7.00017C1.2238 7.00017 0.999939 7.22403 0.999939 7.50017C0.999939 7.77631 1.2238 8.00017 1.49994 8.00017L13.4999 8.00017C13.7761 8.00017 13.9999 7.77631 13.9999 7.50017C13.9999 7.22403 13.7761 7.00017 13.4999 7.00017L1.49994 7.00017Z");
		builder.AddAttribute(17, "fill", "currentColor");
		builder.CloseElement();
		builder.CloseElement();
    }
}
