// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiAndela : ComponentBase
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
		builder.AddAttribute(15, "d", "M20.999 4.586 13.956.511A3.94 3.94 0 0 0 12 0c-.713 0-1.378.183-1.946.511L2.982 4.586a4.013 4.013 0 0 0-1.917 3.42v7.997a3.99 3.99 0 0 0 1.927 3.421l7.014 4.046c.587.337 1.262.53 1.994.53.723 0 1.407-.193 1.994-.53l6.937-4.008a4.008 4.008 0 0 0 2.004-3.468V7.997a4.003 4.003 0 0 0-1.936-3.411Zm.298 7.534h-.038c-5.039.02-9.143 4.143-9.143 9.182a.117.117 0 0 1-.116.116.118.118 0 0 1-.116-.116v-.038c-.019-5.039-4.143-9.144-9.181-9.144a.116.116 0 0 1-.116-.115c0-.068.058-.116.116-.116h.038c5.039-.019 9.143-4.143 9.143-9.182 0-.067.058-.115.116-.115.067 0 .116.058.116.115 0 5.059 4.114 9.182 9.181 9.182.068 0 .116.058.116.116.01.067-.048.115-.116.115Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
