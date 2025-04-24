// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiSpinningTop : ComponentBase
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
		builder.AddAttribute(14, "d", "M81.524 176.5C47.946 133.786 38.598 114.37 36 106.534a27.408 27.408 0 0 1 30.514-7.851l230.6 84.722a52.994 52.994 0 0 1 31.474 31.474l84.722 230.6a27.408 27.408 0 0 1-7.851 30.514c-7.794-2.584-27.252-11.946-69.966-45.524-40.342-31.714-87.815-74.428-133.664-120.277-45.848-45.849-88.59-93.35-120.305-133.692zm104.307 149.676c-49.576-49.577-96.569-102.245-128.905-144.494a692.302 692.302 0 0 1-13.259-17.862l47.91 109.842a164.502 164.502 0 0 1 4.59 119.783l-11.932 34.313 34.313-11.932a164.502 164.502 0 0 1 119.783 4.59l109.842 47.91a692.283 692.283 0 0 1-17.862-13.26c-42.234-32.363-94.903-79.356-144.48-128.932zm281.56-281.56a29.413 29.413 0 0 0-41.585 0L387.33 83.08l41.556 41.556 38.52-38.52a29.413 29.413 0 0 0 0-41.556zM339.319 187.712l60.35-60.35-15.066-15.01-60.35 60.293a73.92 73.92 0 0 1 15.066 15.067z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
