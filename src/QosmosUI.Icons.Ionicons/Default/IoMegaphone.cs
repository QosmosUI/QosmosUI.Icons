// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoMegaphone : ComponentBase
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
		builder.AddAttribute(14, "d", "M48,176v.66a17.38,17.38,0,0,1-4.2,11.23l0,.05C38.4,194.32,32,205.74,32,224c0,16.55,5.3,28.23,11.68,35.91A19,19,0,0,1,48,272h0a32,32,0,0,0,32,32h8a8,8,0,0,0,8-8V152a8,8,0,0,0-8-8H80A32,32,0,0,0,48,176Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M452.18,186.55l-.93-.17a4,4,0,0,1-3.25-3.93V62c0-12.64-8.39-24-20.89-28.32-11.92-4.11-24.34-.76-31.68,8.53A431.18,431.18,0,0,1,344.12,93.9c-23.63,20-46.24,34.25-67,42.31a8,8,0,0,0-5.15,7.47V299a16,16,0,0,0,9.69,14.69c19.34,8.29,40.24,21.83,62,40.28a433.74,433.74,0,0,1,51.68,52.16A26.22,26.22,0,0,0,416.44,416a33.07,33.07,0,0,0,10.44-1.74C439.71,410,448,399.05,448,386.4V265.53a4,4,0,0,1,3.33-3.94l.85-.14C461.8,258.84,480,247.67,480,224S461.8,189.16,452.18,186.55Z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M240,320V152a8,8,0,0,0-8-8H136a8,8,0,0,0-8,8V456a24,24,0,0,0,24,24h52.45a32.66,32.66,0,0,0,25.93-12.45,31.65,31.65,0,0,0,5.21-29.05c-1.62-5.18-3.63-11-5.77-17.19-7.91-22.9-18.34-37.07-21.12-69.32A32,32,0,0,0,240,320Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
