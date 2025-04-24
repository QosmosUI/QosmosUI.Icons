// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiVtex : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M22.2027 1.7925H4.2812c-1.3897 0-2.2795 1.4698-1.6293 2.6917l1.7927 3.3773H1.1947a1.2 1.2 0 0 0-.5873.1537 1.1924 1.1924 0 0 0-.4356.421 1.1847 1.1847 0 0 0-.0342 1.1683l5.766 10.858c.1017.191.2537.3507.4399.4622a1.1996 1.1996 0 0 0 1.2326 0 1.1913 1.1913 0 0 0 .4398-.4623l1.566-2.933 1.9647 3.7006c.6914 1.3016 2.5645 1.304 3.2584.0038L23.7878 4.416c.635-1.1895-.2314-2.6235-1.5851-2.6235ZM14.1524 8.978l-3.8733 7.2533a.7932.7932 0 0 1-.2927.3074.7986.7986 0 0 1-.82 0 .7933.7933 0 0 1-.2927-.3074L5.0378 9.0086a.7883.7883 0 0 1 .0208-.7776.7933.7933 0 0 1 .2891-.281.7985.7985 0 0 1 .3906-.1033h7.7307a.7769.7769 0 0 1 .381.0998.7717.7717 0 0 1 .2823.2736.7672.7672 0 0 1 .02.758z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
