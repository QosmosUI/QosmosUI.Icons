// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiShears : ComponentBase
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
		builder.AddAttribute(14, "d", "M94.85 31.59c-1.43 2.7-2.79 5.88-3.87 9.77-2.55 9.22-3.8 21.14-3.66 33.46.29 24.64 6.87 51.38 14.38 61.68l.1.2.1.1c28.5 42.7 64 81.1 99.2 120.3 1.6-5.7 4.1-11.1 7.3-16l-79-96.9-5.5-35.2 96.7 118.8c3.9-3.1 8.1-5.7 12.7-7.6-49.6-58.5-99.9-126.31-138.45-188.61zm322.35 0c-38.6 62.3-88.9 130.11-138.5 188.61 4.6 1.9 8.8 4.5 12.7 7.6L388.1 109l-2.9 18.9-2.6 16.3-79 96.9c3.2 4.9 5.7 10.2 7.3 16 35.2-39.2 70.7-77.6 99.2-120.3l.1-.1.1-.2c7.5-10.3 14.1-37.04 14.4-61.68.1-12.32-1.1-24.24-3.7-33.46-1.1-3.89-2.4-7.07-3.8-9.77zM256 233.4c-21.6 0-39 17.4-39 39s17.4 39 39 39 39-17.4 39-39c0-9.2-3.2-17.7-8.5-24.4-7.2-8.9-18.1-14.6-30.5-14.6zm0 14c13.7 0 25 11.3 25 25s-11.3 25-25 25-25-11.3-25-25 11.3-25 25-25zm0 18c-4 0-7 3-7 7s3 7 7 7 7-3 7-7-3-7-7-7zm-51.8 30.7c-13.8 9-27.1 18-38 27.5l23 16.9c5.6-6.7 12.7-12.5 20-17.9 3.2-2.4 6.4-4.8 9.6-7.1-6.2-5.3-11.2-11.9-14.6-19.4zm103.6 0c-3.4 7.5-8.4 14.1-14.6 19.4 3.2 2.3 6.4 4.7 9.6 7.1 7.3 5.4 14.4 11.2 20 17.9l23-16.8c-10.9-9.5-24.2-18.6-38-27.6zm-174.5 25.7l-23.5 21.6 74.3 54.9 14-29-64.8-47.5zm245.4 0l-64.8 47.5 14 29 74.3-54.9-23.5-21.6zM114.2 369L53 452.3c-14.01 19.4 32.48 48.7 44.28 32.2l60.12-83.6-43.2-31.9zm283.6 0l-43.2 31.9 60.1 83.6c11.8 16.5 58.3-12.8 44.3-32.2L397.8 369z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
