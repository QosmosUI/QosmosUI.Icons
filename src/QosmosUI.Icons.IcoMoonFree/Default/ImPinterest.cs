// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree.Default;

public class ImPinterest : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "d", "M8 1.069c-3.828 0-6.931 3.103-6.931 6.931 0 2.938 1.828 5.444 4.406 6.453-0.059-0.547-0.116-1.391 0.025-1.988 0.125-0.541 0.813-3.444 0.813-3.444s-0.206-0.416-0.206-1.028c0-0.963 0.559-1.684 1.253-1.684 0.591 0 0.878 0.444 0.878 0.975 0 0.594-0.378 1.484-0.575 2.306-0.166 0.691 0.344 1.253 1.025 1.253 1.231 0 2.178-1.3 2.178-3.175 0-1.659-1.194-2.819-2.894-2.819-1.972 0-3.128 1.478-3.128 3.009 0 0.597 0.228 1.234 0.516 1.581 0.056 0.069 0.066 0.128 0.047 0.2-0.053 0.219-0.169 0.691-0.194 0.787-0.031 0.128-0.1 0.153-0.231 0.094-0.866-0.403-1.406-1.669-1.406-2.684 0-2.188 1.587-4.194 4.578-4.194 2.403 0 4.272 1.712 4.272 4.003 0 2.388-1.506 4.313-3.597 4.313-0.703 0-1.362-0.366-1.588-0.797 0 0-0.347 1.322-0.431 1.647-0.156 0.603-0.578 1.356-0.862 1.816 0.65 0.2 1.337 0.309 2.053 0.309 3.828 0 6.931-3.103 6.931-6.931 0-3.831-3.103-6.934-6.931-6.934z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
