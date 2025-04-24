// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiSlipknot : ComponentBase
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
		builder.AddAttribute(14, "d", "M237 23v113.1l38 5.6V23h-38zm-34.5 126.2c-.3.2-.7.8-1.3 2C200 154 199 159 199 164c0 5 1 10 2.2 12.8.6 1.3 1.2 2 1.4 2.2h.1l106.8 15.8c.3-.2.7-.8 1.3-2C312 190 313 185 313 180c0-5-1-10-2.2-12.8-.6-1.3-1.2-2-1.4-2.2h-.1l-106.8-15.8zm0 48c-.3.2-.7.8-1.3 2C200 202 199 207 199 212c0 5 1 10 2.2 12.8.6 1.3 1.2 2 1.4 2.2h.1l106.8 15.8c.3-.2.7-.8 1.3-2C312 238 313 233 313 228c0-5-1-10-2.2-12.8-.6-1.3-1.2-2-1.4-2.2h-.1l-106.8-15.8zm3.1 48.4c-5.2 6.5-10.5 13.3-15.9 20.6-26.3 35.8-54.3 79.4-47.5 122.6 4.2 26.7 19.5 51.4 39.8 70.4 20.2 19 46.1 32.8 74 32.8s53.8-13.8 74-32.8c20.3-19 35.6-43.7 39.8-70.4 6.8-43.2-21.2-86.8-47.5-122.6-1.7-2.4-3.4-4.6-5.1-6.9-2.2 1.1-4.7 1.7-7.2 1.7h-.7l-42.2-6.3c7.7 8.9 16.6 19.7 26.2 32.8 24.3 33.2 44.3 74.6 40.9 95.7-2.6 16.2-13.6 35.5-28.8 49.8-15.2 14.2-33.9 23-49.4 23s-34.2-8.8-49.4-23c-15.2-14.3-26.2-33.6-28.8-49.8-3.4-21.1 16.6-62.5 40.9-95.7 10.6-14.5 20.4-26.3 28.7-35.7l-41.8-6.2z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
