// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoReceipt : ComponentBase
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
		builder.AddAttribute(14, "d", "M483.82,32.45a16.28,16.28,0,0,0-11.23,1.37L448,46.1h0l-24.8-12.4a16,16,0,0,0-14.31,0L383.78,46.11h0L359,33.7a16,16,0,0,0-14.36,0L320,46.07H320L295.55,33.73a16,16,0,0,0-14.35-.06L256,46.12h0l-24.8-12.43a16.05,16.05,0,0,0-14.33,0L192,46.1h0L167.16,33.69a16,16,0,0,0-19.36,3.94A16.25,16.25,0,0,0,144,48.28V288a0,0,0,0,0,.05.05H336a32,32,0,0,1,32,32V424c0,30.93,33.07,56,64,56h12a52,52,0,0,0,52-52V48A16,16,0,0,0,483.82,32.45ZM416,240H288.5c-8.64,0-16.1-6.64-16.48-15.28A16,16,0,0,1,288,208H415.5c8.64,0,16.1,6.64,16.48,15.28A16,16,0,0,1,416,240Zm0-80H224.5c-8.64,0-16.1-6.64-16.48-15.28A16,16,0,0,1,224,128H415.5c8.64,0,16.1,6.64,16.48,15.28A16,16,0,0,1,416,160Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M336,424V336a16,16,0,0,0-16-16H48a32.1,32.1,0,0,0-32,32.05c0,50.55,5.78,71.57,14.46,87.57C45.19,466.79,71.86,480,112,480H357.68a4,4,0,0,0,2.85-6.81C351.07,463.7,336,451,336,424Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
