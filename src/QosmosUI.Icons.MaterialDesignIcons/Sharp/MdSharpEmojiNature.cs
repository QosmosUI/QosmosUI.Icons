// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Sharp;

public class MdSharpEmojiNature : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.OpenElement(14, "rect");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "height", "24");
		builder.AddAttribute(17, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "g");
		builder.CloseElement();
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M21.94,4.88C21.76,4.35,21.25,4,20.68,4c-0.03,0-0.06,0-0.09,0H19.6l-0.31-0.97C19.15,2.43,18.61,2,18,2h0 c-0.61,0-1.15,0.43-1.29,1.04L16.4,4h-0.98c-0.03,0-0.06,0-0.09,0c-0.57,0-1.08,0.35-1.26,0.88c-0.19,0.56,0.04,1.17,0.56,1.48 l0.87,0.52L15.1,8.12c-0.23,0.58-0.04,1.25,0.45,1.62C15.78,9.91,16.06,10,16.33,10c0.31,0,0.61-0.11,0.86-0.32L18,8.98l0.81,0.7 C19.06,9.89,19.36,10,19.67,10c0.27,0,0.55-0.09,0.78-0.26c0.5-0.37,0.68-1.04,0.45-1.62l-0.39-1.24l0.87-0.52 C21.89,6.05,22.12,5.44,21.94,4.88z M18,7c-0.55,0-1-0.45-1-1c0-0.55,0.45-1,1-1s1,0.45,1,1C19,6.55,18.55,7,18,7z");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M13.49,10.51c-0.43-0.43-0.94-0.73-1.49-0.93V8h-1v1.38c-0.11-0.01-0.23-0.03-0.34-0.03c-1.02,0-2.05,0.39-2.83,1.17 c-0.16,0.16-0.3,0.34-0.43,0.53L6,10.52c-1.56-0.55-3.28,0.27-3.83,1.82c0,0,0,0,0,0c-0.27,0.75-0.23,1.57,0.12,2.29 c0.23,0.48,0.58,0.87,1,1.16c-0.38,1.35-0.06,2.85,1,3.91c1.06,1.06,2.57,1.38,3.91,1c0.29,0.42,0.68,0.77,1.16,1 C9.78,21.9,10.21,22,10.65,22c0.34,0,0.68-0.06,1.01-0.17c0,0,0,0,0,0c1.56-0.55,2.38-2.27,1.82-3.85l-0.52-1.37 c0.18-0.13,0.36-0.27,0.53-0.43c0.87-0.87,1.24-2.04,1.14-3.17H16v-1h-1.59C14.22,11.46,13.92,10.95,13.49,10.51z M4.67,14.29 c-0.25-0.09-0.45-0.27-0.57-0.51s-0.13-0.51-0.04-0.76c0.19-0.52,0.76-0.79,1.26-0.61l3.16,1.19C7.33,14.2,5.85,14.71,4.67,14.29z M10.99,19.94c-0.25,0.09-0.52,0.08-0.76-0.04c-0.24-0.11-0.42-0.32-0.51-0.57c-0.42-1.18,0.09-2.65,0.7-3.8l1.18,3.13 C11.78,19.18,11.51,19.76,10.99,19.94z M12.2,14.6l-0.61-1.61c0-0.01-0.01-0.02-0.02-0.03c-0.02-0.04-0.04-0.08-0.06-0.12 c-0.02-0.04-0.04-0.07-0.07-0.11c-0.03-0.03-0.06-0.06-0.09-0.09c-0.03-0.03-0.06-0.06-0.09-0.09c-0.03-0.03-0.07-0.05-0.11-0.07 c-0.04-0.02-0.07-0.05-0.12-0.06c-0.01,0-0.02-0.01-0.03-0.02L9.4,11.8c0.36-0.29,0.79-0.46,1.26-0.46c0.53,0,1.04,0.21,1.41,0.59 C12.8,12.66,12.84,13.81,12.2,14.6z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
