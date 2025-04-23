// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons;

public class GrAruba : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "fill-rule", "evenodd");
		builder.AddAttribute(15, "d", "M12.1099561,17.3015551 C9.03598293,17.3015551 6.50849391,14.8423766 6.50849391,11.836714 C6.50849391,8.83105139 9.03598293,6.37187289 12.1099561,6.37187289 C15.1839292,6.37187289 17.7114182,8.83105139 17.7114182,11.836714 C17.7114182,14.8423766 15.1839292,17.3015551 12.1099561,17.3015551 L12.1099561,17.3015551 Z M12.1099561,2 C6.50849391,2 2,6.4401834 2,11.836714 C2,17.3015551 6.50849391,21.673428 12.1099561,21.673428 C14.4325135,21.673428 16.5501395,20.9220123 18.2579023,19.6241126 C19.28256,21.3318754 22.2199121,21.673428 22.2199121,21.673428 L22.2199121,11.836714 C22.2199121,6.4401834 17.7114182,2 12.1099561,2 L12.1099561,2 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
