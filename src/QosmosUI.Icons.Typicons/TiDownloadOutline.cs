// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons;

public class TiDownloadOutline : ComponentBase
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
		builder.AddAttribute(14, "d", "M20.986 17c0-.105-.004-.211-.038-.316l-2-6c-.136-.409-.516-.684-.948-.684h-.561l.682-.678c1.17-1.17 1.17-3.072 0-4.242-.81-.812-2.068-1.078-3.121-.709v-1.371c0-1.654-1.346-3-3-3s-3 1.346-3 3v1.371c-1.052-.369-2.311-.103-3.121.709-1.17 1.17-1.17 3.072.002 4.244l.68.676h-.561c-.432 0-.812.275-.948.684l-2 6c-.034.105-.038.211-.038.316-.014 0-.014 5-.014 5 0 .553.447 1 1 1h16c.553 0 1-.447 1-1 0 0 0-5-.014-5zm-13.693-10.506c.189-.187.439-.293.707-.293s.518.104.707.293l2.293 2.293v-5.787c0-.552.448-1 1-1s1 .448 1 1v5.787l2.293-2.293c.379-.377 1.035-.377 1.414 0 .391.39.391 1.023.002 1.412l-4.709 4.684-4.707-4.682c-.391-.388-.391-1.024 0-1.414zm-.572 5.506h1.852l3.429 3.41 3.428-3.41h1.852l1.667 5h-13.894l1.666-5zm12.279 9h-14v-3h14v3z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
