// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiHeavyBullets : ComponentBase
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
		builder.AddAttribute(14, "d", "M96 36.61L41.21 173.6c.26.6.84 1.4 2.15 2.5 2.16 1.8 6.2 4 11.49 5.8 10.57 3.5 25.9 5.5 41.15 5.5 15.2 0 30.6-2 41.2-5.5 5.2-1.8 9.3-4 11.4-5.8 1.3-1.2 1.9-1.9 2.2-2.5zm160 0L201.2 173.6c.3.6.9 1.3 2.2 2.5 2.1 1.8 6.2 4 11.4 5.8 10.6 3.5 26 5.5 41.2 5.5 15.3 0 30.6-2 41.2-5.5 5.2-1.8 9.3-4 11.4-5.8 1.3-1.2 1.9-1.9 2.2-2.5zm160 0L361.2 173.6c.3.6.9 1.3 2.2 2.5 2.1 1.8 6.2 4 11.4 5.8 10.6 3.5 26 5.5 41.2 5.5 15.2 0 30.6-2 41.2-5.5 5.2-1.8 9.3-4 11.4-5.8 1.3-1.2 1.9-1.9 2.2-2.5zM41 195.7v17c0 1 .2 1.8 2.36 3.7 2.16 1.8 6.2 4 11.49 5.8 10.57 3.5 25.9 5.5 41.15 5.5 15.2 0 30.6-2 41.2-5.5 5.2-1.8 9.3-4 11.4-5.8 2.2-1.9 2.4-2.7 2.4-3.7v-17c-2.6 1.2-5.3 2.3-8.2 3.2-13.4 4.5-30 6.5-46.8 6.5-16.75 0-33.42-2-46.85-6.5-2.87-.9-5.59-2-8.15-3.2zm160 0v17c0 1 .2 1.8 2.4 3.7 2.1 1.8 6.2 4 11.4 5.8 10.6 3.5 26 5.5 41.2 5.5 15.3 0 30.6-2 41.2-5.5 5.2-1.8 9.3-4 11.4-5.8 2.2-1.9 2.4-2.7 2.4-3.7v-17c-2.6 1.2-5.3 2.3-8.2 3.2-13.4 4.5-30 6.5-46.8 6.5-16.8 0-33.4-2-46.8-6.5-2.9-.9-5.6-2-8.2-3.2zm160 0v17c0 1 .2 1.8 2.4 3.7 2.1 1.8 6.2 4 11.4 5.8 10.6 3.5 26 5.5 41.2 5.5 15.2 0 30.6-2 41.2-5.5 5.2-1.8 9.3-4 11.4-5.8 2.2-1.9 2.4-2.7 2.4-3.7v-17c-2.6 1.2-5.3 2.3-8.2 3.2-13.4 4.5-30 6.5-46.8 6.5-16.8 0-33.4-2-46.8-6.5-2.9-.9-5.6-2-8.2-3.2zM41 236v158.3l17.06 34.1-16.71 33.4c.3.6.87 1.3 2.01 2.3 2.16 1.8 6.2 4 11.49 5.8 10.57 3.5 25.9 5.5 41.15 5.5 15.2 0 30.6-2 41.2-5.5 5.2-1.8 9.3-4 11.4-5.8 1.2-1 1.7-1.7 2.1-2.3l-16.8-33.4 17.1-34.1V236c-2.6 1.2-5.3 2.3-8.2 3.2-13.4 4.5-30 6.5-46.8 6.5-16.75 0-33.42-2-46.85-6.5-2.87-.9-5.59-2-8.15-3.2zm160 0v158.3l17.1 34.1-16.8 33.4c.4.6.9 1.3 2.1 2.3 2.1 1.8 6.2 4 11.4 5.8 10.6 3.5 26 5.5 41.2 5.5 15.3 0 30.6-2 41.2-5.5 5.2-1.8 9.3-4 11.4-5.8 1.2-1 1.7-1.7 2.1-2.3l-16.8-33.4 17.1-34.1V236c-2.6 1.2-5.3 2.3-8.2 3.2-13.4 4.5-30 6.5-46.8 6.5-16.8 0-33.4-2-46.8-6.5-2.9-.9-5.6-2-8.2-3.2zm160 0v158.3l17.1 34.1-16.8 33.4c.4.6.9 1.3 2.1 2.3 2.1 1.8 6.2 4 11.4 5.8 10.6 3.5 26 5.5 41.2 5.5 15.2 0 30.6-2 41.2-5.5 5.2-1.8 9.3-4 11.4-5.8 1.2-1 1.7-1.7 2.1-2.3l-16.8-33.4 17.1-34.1V236c-2.6 1.2-5.3 2.3-8.2 3.2-13.4 4.5-30 6.5-46.8 6.5-16.8 0-33.4-2-46.8-6.5-2.9-.9-5.6-2-8.2-3.2z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
