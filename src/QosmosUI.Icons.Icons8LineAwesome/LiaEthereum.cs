// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaEthereum : ComponentBase
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
		builder.AddAttribute(14, "d", "M 14.953125 3 L 6.9296875 15.552734 L 16.003906 20.013672 L 24.933594 15.548828 L 17.052734 3 L 16.5 3 L 14.953125 3 z M 15 6.6367188 L 15 10.988281 L 11.085938 12.763672 L 15 6.6367188 z M 17 6.6777344 L 20.818359 12.757812 L 17 11.003906 L 17 6.6777344 z M 15 13.183594 L 15 17.291016 L 10.65625 15.154297 L 15 13.183594 z M 17 13.207031 L 21.246094 15.15625 L 17 17.279297 L 17 13.207031 z M 7 17.511719 L 7 20.03125 L 14.927734 28.875 L 16 28.875 L 17.072266 28.875 L 25 20.03125 L 25 17.511719 L 16 22.125 L 7 17.511719 z M 11.521484 22.078125 L 15 23.861328 L 15 25.957031 L 11.521484 22.078125 z M 20.478516 22.078125 L 17 25.957031 L 17 23.861328 L 20.478516 22.078125 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
