// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoLogoFirefox : ComponentBase
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
		builder.AddAttribute(14, "d", "M471.46,194.62v-.07c-.22-.76-.45-1.52-.68-2.28-.05-.19-.11-.38-.17-.56-.43-1.44-.87-2.88-1.33-4.31l-.06-.2a223.24,223.24,0,0,0-10-25.56,191.77,191.77,0,0,0-12.9-23.8A225.15,225.15,0,0,0,371.58,64.1h0A222.9,222.9,0,0,0,256,32c-7,0-14,.34-20.82,1-24.12,2.54-64.78,11.21-97.77,40.18C257.5,11.86,417.94,85.7,404.29,223c-4.86,49-46.46,82.67-85.19,88.35a73.73,73.73,0,0,1-20.8.21c-94.59-13.15-88.8-90.68-60.06-123.83-38-.24-67.47,46.79-53.15,93l0,0c-32.95-61.18.35-157,70.93-186-82.95-12-160.71,28.2-185.7,98.07A330.23,330.23,0,0,1,88.07,118s-45.22,35.74-54.44,110.9c-.14,1.16-.27,2.32-.39,3.49-.05.4-.09.8-.13,1.21q-.53,5.25-.8,10.57c0,.27,0,.54,0,.81-.07,1.48-.13,3-.17,4.46l0,1.25c0,1.76-.07,3.52-.07,5.29,0,123.71,100.29,224,224,224S480,379.71,480,256A224,224,0,0,0,471.46,194.62Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
