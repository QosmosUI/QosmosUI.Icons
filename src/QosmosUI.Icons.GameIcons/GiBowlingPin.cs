// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiBowlingPin : ComponentBase
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
		builder.AddAttribute(14, "d", "M253.906 17.594c-19.943.246-29.027 6.66-34.687 17.093-5.668 10.445-7.04 26.44-5.657 44.313s5.284 37.398 8.5 55.063c1.293 7.107 2.494 13.83 3.375 20.156H286.5c.894-6.445 2.18-13.313 3.5-20.564 3.25-17.83 7.19-37.542 8.5-55.5 1.31-17.957-.25-33.9-6.156-44.187-5.907-10.288-15.443-16.607-36.25-16.376h-.188c-.65-.008-1.31-.008-1.937 0h-.064zM226.75 170.22c-.003 3.266-.216 6.37-.72 9.31-1.194 6.994-2.872 13.607-4.874 19.94h69.688c-2.002-6.332-3.68-12.946-4.875-19.94-.503-2.935-.715-6.048-.72-9.31h-58.5zm-18.688 61.25c-9.445 19.785-19.865 38.882-25.5 62.186-10.055 41.59-6.585 98.32 43.813 199.094 23.952 1.804 17.156 1.583 29.594 1.625h.06c12.43-.042 5.676.175 29.564-1.625 50.4-100.776 53.894-157.504 43.844-199.094-5.632-23.304-16.054-42.4-25.5-62.187h-95.875z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
