// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Devicons.Default;

public class DiBlackberry : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "32";

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
    public string ViewBox { get; set; } = "0 0 32 32";

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
		builder.AddAttribute(14, "d", "M24.177 15.734c-1.481 0-3.077 0-3.077 0l0.839-3.897c0 0 2.166 0 2.955 0 1.917 0 2.371 0.947 2.371 1.696 0 1.060-0.683 2.201-3.088 2.201zM26.12 19.085c0 1.060-0.682 2.201-3.088 2.201-1.481 0-3.077 0-3.077 0l0.839-3.9c0 0 2.166 0 2.953 0 1.917-0 2.374 0.953 2.374 1.699zM17.014 12.246c-1.481 0-3.074 0-3.074 0l0.839-3.897c0 0 2.163 0 2.95 0 1.92 0 2.377 0.947 2.377 1.696 0 1.060-0.685 2.201-3.091 2.201zM19.035 15.911c0 1.060-0.682 2.201-3.088 2.201-1.479 0-3.074 0-3.074 0l0.837-3.895c0 0 2.166 0 2.954 0 1.917 0 2.371 0.944 2.371 1.693zM17.893 22.021c0 1.063-0.682 2.201-3.083 2.201-1.484 0-3.081 0-3.081 0l0.839-3.9c0 0 2.166 0 2.955 0 1.916 0 2.37 0.95 2.37 1.699zM8.781 12.246c-1.479 0-3.073 0-3.073 0l0.834-3.897c0 0 2.166 0 2.955 0 1.917 0 2.376 0.947 2.376 1.696-0 1.060-0.687 2.201-3.093 2.201zM10.807 15.911c0 1.060-0.687 2.201-3.087 2.201-1.485 0-3.081 0-3.081 0l0.84-3.895c0 0 2.168 0 2.953 0 1.919 0 2.376 0.944 2.376 1.693z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
