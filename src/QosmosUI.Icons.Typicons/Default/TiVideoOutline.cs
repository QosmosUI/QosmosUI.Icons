// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons.Default;

public class TiVideoOutline : ComponentBase
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
		builder.OpenElement(13, "circle");
		builder.AddAttribute(14, "cx", "7");
		builder.AddAttribute(15, "cy", "11");
		builder.AddAttribute(16, "r", "1");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M21.585 7.188c-.262-.188-.599-.241-.901-.137l-1.707.568c-.188-1.477-1.451-2.62-2.977-2.62h-11c-1.654 0-3 1.347-3 3v6c0 1.653 1.346 3 3 3h3v1.111l.008.09c.066.738.381 1.423.887 1.928.562.562 1.311.872 2.104.872s1.542-.31 2.104-.87c.574-.577.898-1.346.896-2.113v-1.017h2c1.524 0 2.789-1.145 2.978-2.62l1.707.568c.303.104.64.051.9-.138.262-.188.415-.49.415-.812v-6c.001-.318-.153-.621-.414-.81zm-9.585 10.835c.001.248-.119.5-.309.689-.191.189-.441.286-.692.286-.25 0-.501-.097-.69-.286-.19-.189-.285-.441-.309-.691v-2.021h2v2.023zm5-4.023c0 .552-.448 1-1 1h-11c-.552 0-1-.448-1-1v-6c0-.552.448-1 1-1h11c.552 0 1 .448 1 1v6zm3-1.389s-1.895-.605-2-.605v-2.012c.105 0 2-.605 2-.605v3.222z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
