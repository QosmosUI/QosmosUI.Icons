// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoEyedrop : ComponentBase
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
		builder.AddAttribute(14, "d", "M461.05,51a65,65,0,0,0-45.71-19h-.76a61.81,61.81,0,0,0-44.36,19.25,12.81,12.81,0,0,0-1.07,1.25l-54,69.76c-5.62,7.1-12.74,8.68-16.78,4.64L296.47,125a48,48,0,0,0-67.92,67.92l9.91,9.91a2,2,0,0,1,0,2.83L58.7,385.38C54,390.05,46.9,399.85,38.85,431c-4.06,15.71-6.51,29.66-6.61,30.24A16,16,0,0,0,48,480a15.68,15.68,0,0,0,2.64-.22c.58-.1,14.44-2.43,30.13-6.44,31.07-7.94,41.05-15.24,45.85-20L306.39,273.55a2,2,0,0,1,2.82,0l9.92,9.92a48,48,0,0,0,67.92-67.93L385.46,214c-5-5-2.52-12.11,4.32-17.14l69.75-53.94A17.82,17.82,0,0,0,461,141.6a63.2,63.2,0,0,0,19-45A63.88,63.88,0,0,0,461.05,51ZM250.78,283.9c-2.92,2.92-16.18,7.92-23.39.71s-2.24-20.42.69-23.35l33-33a2,2,0,0,1,2.83,0l19.84,19.83a2,2,0,0,1,0,2.83Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
