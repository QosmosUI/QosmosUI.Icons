// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoHammerSharp : ComponentBase
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
		builder.AddAttribute(14, "d", "M294.28,256.9l-54.42-54.41a12,12,0,0,0-17,0L12.45,401a12,12,0,0,0-.27,17.2l66.05,66.28a12,12,0,0,0,17.22-.23L294.26,273.89A12,12,0,0,0,294.28,256.9Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M499.33,199.33l-43.89-43.58a21.46,21.46,0,0,0-15.28-6.26,21.89,21.89,0,0,0-12.79,4.14c0-.43.06-.85.09-1.22.45-6.5,1.15-16.32-5.2-25.22a258,258,0,0,0-24.8-28.74.6.6,0,0,0-.08-.08c-13.32-13.12-42.31-37.83-86.72-55.94A139.55,139.55,0,0,0,257.56,32C226,32,202,46.24,192.81,54.68A53.4,53.4,0,0,0,176,86.17L192,96s8.06-2,13.86-3.39a62.73,62.73,0,0,1,18.45-1.15C237.5,92.55,253.1,99.1,260,104.55c11.7,9.41,17.33,22.09,18.26,41.09.2,4.23-9.52,21.35-24.16,39.84a8,8,0,0,0,.61,10.62l45.37,45.37a8,8,0,0,0,11,.25c12.07-11,30.49-28,34.67-30.59,7.69-4.73,13.19-5.64,14.7-5.8a19.18,19.18,0,0,1,11.29,2.38,1.24,1.24,0,0,1-.31.95l-1.82,1.73-.3.28a21.52,21.52,0,0,0,.05,30.54l43.95,43.68a8,8,0,0,0,11.28,0l74.68-74.2A8,8,0,0,0,499.33,199.33Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
