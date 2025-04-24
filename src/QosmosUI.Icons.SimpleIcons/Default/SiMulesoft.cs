// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiMulesoft : ComponentBase
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
		builder.AddAttribute(15, "d", "M12 0C5.373 0 0 5.373 0 12c0 6.628 5.373 12 12 12 6.628 0 12-5.373 12-12S18.627 0 12 0zm0 1.055c6.045 0 10.945 4.9 10.945 10.945S18.045 22.945 12 22.945 1.055 18.045 1.055 12c0-6.044 4.9-10.945 10.945-10.945zM7.33 4.364s-2.993 1.647-3.96 5.25c-.647 2.224-.39 4.702.903 6.914a8.957 8.957 0 0 0 3.95 3.596l.802-3.062c-1.801-.85-3.11-2.571-3.11-4.79a5.647 5.647 0 0 1 .943-3.141l3.752 5.866h2.792l3.753-5.866a5.647 5.647 0 0 1 .943 3.14c0 2.22-1.308 3.94-3.109 4.791l.802 3.062a8.957 8.957 0 0 0 3.948-3.594c1.294-2.213 1.551-4.692.904-6.916l.002.003c-.966-3.603-3.96-5.251-3.96-5.251l-.336.527-4.341 6.797h-.003L7.656 4.876z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
