// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiMightyForce : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 28l-32 128c-32-16-64-48-96-96 0 48 0 96 32 128-32 17-64 0-96-32 0 32 0 80 48 112-32 16-64 0-80-32 0 48 16 96 48 128-16 16-48 0-64-16 0 64 48 112 112 144h76.8l16.7-68.6-17.2-86.1-97.9 5s20.3-75.2 34.9-103.7c5-9.6 7.2-18 20-18.3 11.3 0 20.4 9.8 20.4 21.9 0 12-9.1 21.8-20.4 21.8-2.3 0-4.6-.5-6.6-1.3l-5.1 46.8c29.6-8.9 56.9-18.8 84-30.9 0-.1-.1-.2-.1-.3-6.2-8.8-10.4-21.5-10.4-35.7 0-14.1 4.1-26.8 10.4-35.7 6.1-8.9 14.1-13.7 22.5-13.7 8.5 0 16.5 4.8 22.6 13.7 6.2 8.9 10.2 21.6 10.2 35.7 0 14.2-4 26.9-10.2 35.7-.1.3-.5.7-.6.9 27.3 12.1 56.1 20.6 84.3 30.3l-5-46.8c-2.2.8-4.3 1.3-6.7 1.3-11.2 0-20.3-9.8-20.3-21.8 0-12.1 9.1-21.9 20.3-21.9 12.8.3 15.2 8.7 20 18.3 14.8 28.5 35 103.7 35 103.7l-97.9-5-17.2 86.1 16.7 68.6H384c64-32 112-80 112-144-16 16-48 32-64 16 32-32 48-80 48-128-16 32-48 48-80 32 48-32 48-80 48-112-32 32-64 48-96 32 32-32 32-80 32-128-32 48-64 80-96 96z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
