// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Devicons.Default;

public class DiVisualstudio : ComponentBase
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
		builder.AddAttribute(14, "d", "M17.319 9.414c-2.444 2.444-4.5 4.435-4.597 4.435-0.081 0-1.424-0.987-2.962-2.185l-2.784-2.185-2.266 1.133v11.331l2.266 1.133 2.574-2.007c1.425-1.117 2.736-2.12 2.914-2.234 0.324-0.194 0.647 0.097 4.84 4.274l4.484 4.484 2.752-1.117 2.752-1.101v-18.195l-2.104-0.842c-1.149-0.47-2.396-0.955-2.768-1.101l-0.664-0.259-4.435 4.435zM21.706 16.278c0 2.493-0.032 4.532-0.097 4.532-0.227 0-5.73-4.435-5.682-4.581 0.049-0.178 5.471-4.468 5.666-4.468 0.065-0.016 0.114 2.023 0.114 4.516zM8.837 14.659l1.619 1.619-1.619 1.619c-0.89 0.89-1.667 1.619-1.732 1.619-0.081 0-0.13-1.457-0.13-3.237s0.048-3.238 0.13-3.238c0.065 0 0.842 0.729 1.732 1.619z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
