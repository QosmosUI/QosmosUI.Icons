// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiStable : ComponentBase
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
		builder.AddAttribute(14, "d", "M333.1 62.18L24.41 117.3l-.11 30.6 314.1-56.18zM231 129.2l-30 5.4V295h30zM71 157.8l-30 5.4V295h30zM312.5 186c-8.6 6.1-7 24.1 3.5 40.1-21.6 7.5-45.6 17.2-67 25.6V295h16v90.9c41.3-20.8 74.4-52.7 106.8-89 4.6 22.8 33.9 25.9 51.1 28.7 0 0 .9 13.3 7 18.6 9.2 7.8 24.1 13.4 34.6 7.4 9.7-5.6 9.2-25.7 9.1-29.3-.2-7.5-7.3-13.1-13.9-16-18-35-57.4-90.7-90.8-93.1-4.6-.3-11.2.7-19 2.5-13.7-9.2-32.1-23.7-37.4-29.7zM183 272.5c-39.6 2.4-69.5 2.6-94 3V295h94zM25 313v46h222v-46H25zm0 64v46h222v-46zm0 64v46h222v-46z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
