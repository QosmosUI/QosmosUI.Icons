// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiHealthPotion : ComponentBase
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
		builder.AddAttribute(14, "d", "M192 17.65l16 34h96l16-34zm-9 53v51.95h32v22.2c-19.3-9-42.6-8.2-55-8.2-50.5 0-82.1 21.9-99.5 48-17.4 26.1-21.5 55.5-21.5 73 0 52.5 38.6 94.4 83.3 131C167 425.1 219 457.3 249.6 488l6.4 6.3 6.4-6.3c30.6-30.7 82.6-62.9 127.3-99.4 44.7-36.6 83.3-78.5 83.3-131 0-17.5-4.1-46.9-21.5-73s-49-48-99.5-48c-12.4 0-35.7-.8-55 8.2v-22.2h32V70.65zm18 18h110v15.95H201zm32 33.95h46v60.7l15.4-15.3c11.7-11.8 41.6-13.4 57.6-13.4 45.5 0 69.9 18.1 84.5 40 14.6 21.9 18.5 48.5 18.5 63 0 43.5-33.4 81.7-76.7 117-40.7 33.4-89 63.5-122.3 94.7-33.3-31.2-81.6-61.3-122.3-94.7-43.3-35.3-76.7-73.5-76.7-117 0-14.5 3.9-41.1 18.5-63s39-40 84.5-40c16 0 45.9 1.6 57.6 13.4l15.4 15.3zm-41 71c-64 0-80 48-80 80 0 64 80 96 144 144 64-48 144-80 144-144 0-32-16-80-80-80-32 0-48 0-64 48-16-48-32-48-64-48zm125.7 14.6c3.6-.1 5.9.3 5.8.6-16.5 7.3-33.9 24.4-44.6 41.7 0 0-3.2-17.7 9.9-31.9 7.4-8.1 21.1-10.3 28.9-10.4zM192 209.6c-24 21.5-41.3 58.2-47.2 90.4 0 0-19.5-23.7-7.7-53.4 9.8-24.5 50.1-36.5 54.9-37z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
