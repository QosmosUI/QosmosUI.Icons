// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoTennisball : ComponentBase
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
		builder.AddAttribute(14, "d", "M448,256a192.55,192.55,0,0,0,32-2.68A224,224,0,0,0,258.68,32,192.55,192.55,0,0,0,256,64C256,169.87,342.13,256,448,256Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M253.35,480c.94-5.67,1.65-11.4,2.09-17.18.37-4.88.56-9.86.56-14.79,0-105.87-86.13-192-192-192a192.55,192.55,0,0,0-32,2.68A224,224,0,0,0,253.35,480Z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M289.61,222.39A222.53,222.53,0,0,1,224,64a226.07,226.07,0,0,1,2-30A224.1,224.1,0,0,0,34,226a226.07,226.07,0,0,1,30-2,222.53,222.53,0,0,1,158.39,65.61A222.53,222.53,0,0,1,288,448c0,5.74-.22,11.53-.65,17.22q-.5,6.42-1.36,12.79A224.12,224.12,0,0,0,478,286a226.07,226.07,0,0,1-30,2A222.53,222.53,0,0,1,289.61,222.39Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
