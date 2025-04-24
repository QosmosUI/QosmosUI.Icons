// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiAbstract049 : ComponentBase
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
		builder.AddAttribute(14, "d", "m491,21-99.1169,57.8687 99.1169,57.7219v-115.5906zm0,146.4344-99.1169-57.8687v115.5906l99.1169-57.7219zm0,30.6969-99.1169,57.7219 99.1169,57.8687v-115.5906zm0,146.2875-99.1169-57.575v115.5906l99.1169-58.0156zm0,30.9906-99.1169,57.7219 99.1169,57.8687v-115.5906zm-123.5741-354.4094-99.1169,57.8687 99.1169,57.7219v-115.5906zm0,146.4344-99.1169-57.8687v115.5906l99.1169-57.7219zm0,30.6969-99.1169,57.7219 99.1169,57.8687v-115.5906zm0,146.2875-99.1169-57.575v115.5906l99.1169-58.0156zm0,30.9906-99.1169,57.7219 99.1169,57.8687v-115.5906zm-123.7349-296.5406-99.1169-57.8687v115.5906l99.1169-57.7219zm0,30.6969-99.1169,57.8687 99.1169,57.7219v-115.5906zm0,146.2875-99.1169-57.7219v115.5906l99.1169-57.8687zm0,30.9906-99.1169,57.575 99.1169,58.0156v-115.5906zm0,146.2875-99.1169-57.7219v115.5906l99.1169-57.8687zm-123.5742-354.2625-99.1168-57.8687v115.5906l99.1168-57.7219zm0,30.6969-99.1168,57.8687 99.1168,57.7219v-115.5906zm0,146.2875-99.1168-57.7219v115.5906l99.1168-57.8687zm0,30.9906-99.1168,57.575 99.1168,58.0156v-115.5906zm0,146.2875-99.1168-57.7219v115.5906l99.1168-57.8687z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
