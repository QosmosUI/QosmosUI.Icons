// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoUmbrella : ComponentBase
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
		builder.AddAttribute(14, "d", "M414.39,113.61A222.26,222.26,0,0,0,278.06,49.07a8.09,8.09,0,0,1-6.88-5.62,15.79,15.79,0,0,0-30.36,0,8.09,8.09,0,0,1-6.88,5.62A224,224,0,0,0,32,271.52a16.41,16.41,0,0,0,7.24,13.87,16,16,0,0,0,20.07-2.08,51.89,51.89,0,0,1,73.31-.06,15.94,15.94,0,0,0,22.6.15,62.59,62.59,0,0,1,81.49-5.87h0a8.24,8.24,0,0,1,3.29,6.59V431.54c0,8.6-6.6,16-15.19,16.44A16,16,0,0,1,208,432a16,16,0,0,0-16.29-16c-9,.16-15.9,8.11-15.7,17.1A48.06,48.06,0,0,0,223.38,480c26.88.34,48.62-21.93,48.62-48.81V284.12a8.24,8.24,0,0,1,3.29-6.59h0a62.59,62.59,0,0,1,81.4,5.78,16,16,0,0,0,22.62,0,51.91,51.91,0,0,1,73.38,0,16,16,0,0,0,19.54,2.41A16.4,16.4,0,0,0,480,271.51,222.54,222.54,0,0,0,414.39,113.61Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
