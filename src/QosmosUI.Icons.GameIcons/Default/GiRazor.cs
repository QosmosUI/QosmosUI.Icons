// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiRazor : ComponentBase
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
		builder.AddAttribute(14, "d", "M200.9 38.05c-1.7 0-2.9.36-3.6.84-9.3 6.84-14.4 20.81-14.2 36.27.1 7.36 1.6 14.85 4 21.67 8.3-5.28 17.1-10.41 26.3-15.38-.2-1.2-.2-2.38-.2-3.51 0-5.38 1.4-10.15 2.6-14.5 1.2-4.34 2.3-8.28 2.7-11.14.4-2.86.1-4.1-.3-4.65-1.6-2.69-6.4-6.61-11.1-8.39-2.4-.89-4.5-1.21-6.2-1.21zm65.5 42.46c-6.4-.12-13.3 1.3-20.5 4.76h-.1C148.5 130.9 97.96 193 70.73 252.9c-27.27 59.8-31.08 117.5-33.39 154.3-2.8 44.6 18.99 63.6 40.84 66.4 21.92 2.7 44.82-10.6 47.32-43.5C133.1 330 162.2 229 291.7 139.7l-.2.1c8.9-6.5 12.3-13.7 13-21.1.6-7.4-1.9-15.4-7.1-22.13-6.4-8.46-16.3-14.89-28.3-15.95-.9-.1-1.8-.13-2.7-.15zm-30 29.09c13.7 0 25 11.3 25 25s-11.3 25-25 25-25-11.3-25-25 11.3-25 25-25zm0 18c-4 0-7 3-7 7s3 7 7 7 7-3 7-7-3-7-7-7zm52.4 36.3c-8.4 6.1-16.3 12.3-23.8 18.5l57.8 57.8 6.3 6.4-11.4 11.3 142.7 142.7c1.7-2.5 3.3-5 4.7-7.5 5.8-10 9.5-20 9.8-28.7.4-8.7-1.9-16.2-9.5-23.7-58.8-58.9-117.7-117.9-176.6-176.8zM305 270.7l-21.2 21.2 145.6 145.6c6.2-6.3 13.3-13.9 20.2-22.2z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
