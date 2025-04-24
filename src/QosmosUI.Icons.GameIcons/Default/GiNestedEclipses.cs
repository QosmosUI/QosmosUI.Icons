// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiNestedEclipses : ComponentBase
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
		builder.AddAttribute(14, "d", "M255.225 46.588c-26.494 0-47.772 21.275-47.772 47.77 0 26.495 21.278 47.775 47.772 47.775 26.493 0 47.77-21.28 47.77-47.774 0-26.497-21.276-47.772-47.77-47.772zm-69.67 5.285c-32.036 21.7-53.203 57.98-53.203 99.02 0 66.417 54.854 120.078 122.668 120.078 67.813 0 123.035-53.66 123.035-120.077 0-41.04-21.17-77.32-53.205-99.02 17.492 17.676 28.082 41.888 28.082 68.72 0 54.042-43.87 97.915-97.91 97.915-54.042 0-97.913-43.873-97.913-97.916 0-26.83 10.958-51.043 28.45-68.72h-.005zm-63.36 4.666C61.015 97.982 20.59 167.265 20.59 245.64c0 126.838 104.755 229.32 234.26 229.32 129.504 0 234.964-102.482 234.964-229.32 0-78.374-40.426-147.657-101.605-189.1 33.403 33.756 53.624 79.993 53.624 131.237 0 103.206-83.78 186.987-186.984 186.987-103.204 0-186.987-83.78-186.987-186.987 0-51.244 20.928-97.48 54.332-131.238z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
