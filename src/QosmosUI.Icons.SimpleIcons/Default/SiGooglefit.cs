// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiGooglefit : ComponentBase
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
		builder.AddAttribute(15, "d", "M23.218 4.868c-1.235-2.194-3.927-3.356-6.378-2.843-1.11.243-2.173.774-2.979 1.583-.622.613-1.242 1.229-1.864 1.841-.915-.91-1.788-1.937-2.882-2.648a5.98 5.98 0 0 0-3.904-.845c-4.757.578-6.936 6.346-3.615 9.85 3.481 3.418 6.937 6.863 10.413 10.288 3.291-3.251 6.573-6.51 9.871-9.752 2.132-1.831 2.8-5.026 1.338-7.474zM6.162 11.223c-.692-.755-1.511-1.404-2.141-2.208-.821-1.218-.158-3.012 1.26-3.397.781-.256 1.683-.031 2.279.527.627.609 1.236 1.237 1.866 1.843l.005.006a414.706 414.706 0 0 0-3.269 3.229zm5.846 5.758a3300.079 3300.079 0 0 1-3.255-3.22c2.555-2.516 5.103-5.042 7.65-7.566.393-.394.93-.646 1.487-.673 2.086-.154 3.285 2.372 1.801 3.866-2.549 2.542-5.121 5.062-7.683 7.593z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
