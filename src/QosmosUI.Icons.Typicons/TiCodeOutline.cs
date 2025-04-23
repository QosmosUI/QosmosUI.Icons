// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons;

public class TiCodeOutline : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.OpenElement(13, "g");
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M7.828 19c-.801 0-1.555-.312-2.121-.879l-5.121-5.121 5.121-5.121c1.133-1.134 3.112-1.134 4.243.001 1.169 1.168 1.169 3.072-.001 4.241l-.878.879.878.879c1.17 1.169 1.17 3.073 0 4.242-.564.567-1.318.879-2.121.879zm-4.414-6l3.707 3.707c.38.379 1.039.377 1.413.001.391-.391.391-1.025.001-1.415l-2.292-2.293 2.292-2.293c.39-.39.39-1.024 0-1.414-.378-.379-1.036-.377-1.414 0l-3.707 3.707zM16.172 19c-.803 0-1.557-.312-2.122-.88-1.169-1.168-1.169-3.072.001-4.241l.878-.879-.878-.879c-1.17-1.169-1.17-3.073 0-4.242 1.129-1.133 3.109-1.134 4.242 0l5.121 5.121-5.121 5.121c-.566.567-1.32.879-2.121.879zm-.001-10c-.267 0-.518.104-.705.292-.391.391-.391 1.025-.001 1.415l2.292 2.293-2.292 2.293c-.39.39-.39 1.024 0 1.414.377.378 1.035.379 1.414 0l3.707-3.707-3.707-3.707c-.19-.189-.441-.293-.708-.293z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
