// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons.Default;

public class TiPhoneOutline : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M19.502 3.672l-1.795-1.793c-.566-.567-1.32-.879-2.121-.879s-1.555.312-2.121.879l-1.586 1.586c-1.17 1.17-1.17 3.072 0 4.242l1.379 1.379-4.172 4.172-1.379-1.379c-.566-.567-1.32-.879-2.121-.879s-1.555.312-2.121.879l-1.586 1.586c-1.17 1.17-1.17 3.072 0 4.242l1.794 1.793c.465.465 1.796 1.545 4.116 1.545 2.764 0 5.694-1.529 8.711-4.545 6.245-6.246 4.825-11.002 3.002-12.828zm-6.209 1.207l1.586-1.586c.195-.195.451-.293.707-.293s.512.098.707.293l1.083 1.082-3.001 3-1.082-1.082c-.391-.391-.391-1.023 0-1.414zm-10 11.414c-.391-.391-.391-1.023 0-1.414l1.586-1.586c.195-.195.451-.293.707-.293s.512.098.707.293l1.082 1.082-2.999 3-1.083-1.082zm11.793-1.207c-3.083 3.082-5.551 3.959-7.297 3.959-1.349 0-2.267-.523-2.702-.959-.004-.004 2.995-3.004 2.995-3.004l.297.297c.195.195.451.293.707.293s.512-.098.707-.293l5.586-5.586c.391-.391.391-1.023 0-1.414l-.297-.297 3.001-3c1.003 1.004 2.467 4.539-2.997 10.004z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
