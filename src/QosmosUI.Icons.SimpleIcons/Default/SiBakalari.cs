// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiBakalari : ComponentBase
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
		builder.AddAttribute(15, "d", "M12 0c-.385 0-.77.102-1.11.307L2.762 5.193a2.147 2.147 0 0 0-1.043 1.84v9.93a2.15 2.15 0 0 0 1.043 1.843l8.126 4.886c.683.41 1.537.41 2.22 0l8.128-4.886a2.15 2.15 0 0 0 1.043-1.842v-9.93c0-.754-.396-1.452-1.043-1.84L13.11.306A2.152 2.152 0 0 0 12 0Zm-.094 3.462c.224-.001.449.056.65.17l6.192 3.548c.402.23.65.658.65 1.12v1.85c0 .468-.253.898-.66 1.127l-1.296.722 1.295.724c.408.228.661.659.661 1.126v1.849c0 .462-.248.89-.65 1.12l-6.192 3.549a1.29 1.29 0 0 1-1.297-.008l-6.022-3.55a1.29 1.29 0 0 1-.635-1.111V8.3c0-.457.242-.88.635-1.112l6.022-3.547c.2-.118.423-.177.647-.179zm.018 2.782L7.182 9.037v5.924l4.742 2.793 4.894-2.803v-.344l-1.413-.788c-.34-.19-.55-.55-.55-.94V11.12c0-.39.21-.75.55-.94l1.413-.787v-.345z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
