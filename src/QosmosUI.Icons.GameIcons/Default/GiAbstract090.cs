// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiAbstract090 : ComponentBase
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
		builder.AddAttribute(14, "d", "m21,21v56.4c29.3773,0 53.1688,23.7914 53.1688,53.1687s-23.7914,53.1688-53.1688,53.1688v19.0937c29.3773,0 53.1688,23.7914 53.1688,53.1688s-23.7914,53.1688-53.1688,53.1688v19.0937c29.3773,0 53.1688,23.7915 53.1688,53.1688s-23.7914,53.1688-53.1688,53.1688v56.3999h56.4c0-29.3773 23.7914-53.1687 53.1688-53.1687s53.1687,23.7914 53.1687,53.1687h19.0938c0-29.3773 23.7914-53.1687 53.1688-53.1687s53.1687,23.7914 53.1687,53.1687h19.0937c0-29.3773 23.7915-53.1687 53.1688-53.1687s53.1688,23.7914 53.1688,53.1687h56.3999v-56.3999c-29.3773,0-53.1687-23.7914-53.1687-53.1688s23.7914-53.1688 53.1687-53.1688v-19.0937c-29.3773,0-53.1687-23.7914-53.1687-53.1688s23.7914-53.1688 53.1687-53.1688v-19.0937c-29.3773,0-53.1687-23.7914-53.1687-53.1688s23.7914-53.1687 53.1687-53.1687v-56.4h-56.3999c0,29.3773-23.7915,53.1688-53.1688,53.1688s-53.1688-23.7914-53.1688-53.1688h-19.0937c0,29.3773-23.7914,53.1688-53.1687,53.1688s-53.1688-23.7914-53.1688-53.1688h-19.0938c0,29.3773-23.7914,53.1688-53.1687,53.1688s-53.1688-23.7914-53.1688-53.1688h-56.4zm235.0001,112.0656c67.9121,0 122.9343,55.0221 122.9343,122.9344s-55.0222,122.9343-122.9343,122.9343-122.9344-55.0222-122.9344-122.9343 55.0223-122.9344 122.9344-122.9344zm0,38.1875c-46.8044,0-84.7469,37.9425-84.7469,84.7469s37.9425,84.7469 84.7469,84.7469 84.7468-37.9425 84.7468-84.7469-37.9425-84.7469-84.7468-84.7469z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
