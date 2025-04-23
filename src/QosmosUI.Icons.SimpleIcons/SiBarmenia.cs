// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiBarmenia : ComponentBase
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
		builder.AddAttribute(15, "d", "M7.046 13.427v6.395h5.709a5.41 5.41 0 0 0 2.377-.422c1.021-.537 1.532-1.537 1.532-2.999a2.591 2.591 0 0 0-1.492-2.571 5.834 5.834 0 0 0-2.347-.403zm0-9.26v5.287h5.714a4.722 4.722 0 0 0 2.486-.592c.637-.398.955-1.101.955-2.109 0-1.117-.421-1.855-1.263-2.213a8.63 8.63 0 0 0-2.78-.368zm12.761-1.611a6.19 6.19 0 0 1 1.079 3.66 5.433 5.433 0 0 1-1.089 3.531 5.617 5.617 0 0 1-1.791 1.388 5.232 5.232 0 0 1 2.716 2.113 6.474 6.474 0 0 1 .915 3.481 7.069 7.069 0 0 1-1.05 3.854 6.467 6.467 0 0 1-4.316 3.093c-1.093.222-2.207.33-3.322.324H2.361V0H13.72c2.864.046 4.893.899 6.087 2.556");
		builder.CloseElement();
		builder.CloseElement();
    }
}
