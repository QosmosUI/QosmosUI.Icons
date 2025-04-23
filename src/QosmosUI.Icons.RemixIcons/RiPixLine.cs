// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiPixLine : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M14.4727 1.74514L22.2509 9.52334C23.6177 10.8902 23.6177 13.1063 22.2509 14.4731L14.4727 22.2512C13.1059 23.6181 10.8898 23.6181 9.52303 22.2512L1.74486 14.4731C0.378017 13.1063 0.378017 10.8902 1.74486 9.52334L9.52303 1.74514C10.8898 0.378247 13.1059 0.378247 14.4727 1.74514ZM11.9979 14.8266L9.52301 17.3015C9.14344 17.6811 8.69837 17.9552 8.22419 18.124L10.9372 20.837C11.523 21.4228 12.4727 21.4228 13.0585 20.837L15.7716 18.124C15.2974 17.9552 14.8523 17.6811 14.4727 17.3015L11.9979 14.8266ZM5.98823 8.10835L3.15907 10.9376C2.57328 11.5234 2.57328 12.4731 3.15907 13.0589L5.9875 15.8873C6.57328 16.4731 7.52303 16.4731 8.10882 15.8873L10.5836 13.4124C11.3647 12.6314 12.631 12.6314 13.4121 13.4124L15.8869 15.8873C16.4726 16.4729 17.4224 16.4726 18.0083 15.8873L20.8367 13.0589C21.4225 12.4731 21.4225 11.5234 20.8367 10.9376L18.0083 8.10905C17.4225 7.52435 16.4724 7.52365 15.8869 8.10905L13.4121 10.584C12.631 11.3651 11.3647 11.3651 10.5836 10.584L8.10882 8.10905C7.52328 7.52355 6.57408 7.52335 5.98823 8.10835ZM10.9372 3.15935L8.22419 5.87235C8.69837 6.04115 9.14344 6.31535 9.52301 6.69485L11.9979 9.16975L14.4727 6.69485C14.8523 6.31535 15.2974 6.04115 15.7716 5.87235L13.0585 3.15935C12.4727 2.57355 11.523 2.57355 10.9372 3.15935Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
